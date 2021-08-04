using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using CryptoPro.Sharpei.Xml;
using GisGmp;
using GisGmp.Common;
using GisGmp.SearchConditions;
using SMEV3v12;
using SMEV3v12.Types;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
			SMEVMessageExchangePortTypeClient client = new SMEVMessageExchangePortTypeClient();
			client.Endpoint.Behaviors.Add(new InspectorBehavior());

			//ГИС ГМП
			GisGmpBuilder gisgmp = new GisGmpBuilder()
			{
				SenderIdentifier = "30d677",
				SenderRole = "1",
				PageLength = 100,
				PageNumber = 1,
			};

			var request = gisgmp.CreateExportPaymentsRequest(
					paymentsKind: ExportPaymentsKind.PAYMENT,
					timeInterval: new TimeIntervalType(DateTime.Now.AddDays(-1), DateTime.Now),
					kbk: new KBKType[] { "21220300000000000130" }
					);

			var xmlRequest = GisGmpBuilder.SerializerObject(request);


            try
            {
                SenderProvidedRequestData senderProvidedRequestData = new SenderProvidedRequestData()
                {
                    Id = "SMEV",//"C_" + Guid.NewGuid().ToString(),
                    MessageID = GuidGenerator.GenerateTimeBasedGuid().ToString(),
                    MessagePrimaryContent = GisGmpBuilder.SerializerObject(request).DocumentElement,
                    TestMessage = new SMEV3v12.Types.Basic.Void(),
                    PersonalSignature = GisGmpBuilder.SerializerObject(Signed(xmlRequest, x509Certificate2(), request.Id)).DocumentElement,

                };
                XmlDocument xmlDoc = GisGmpBuilder.SerializerObject(senderProvidedRequestData);

                //Проверить ЭП-СП
                var valid = Verification(GisGmpBuilder.SerializerObject(senderProvidedRequestData));



                var smevSing = GisGmpBuilder.SerializerObject(Signed(xmlDoc, x509Certificate2(), senderProvidedRequestData.Id)).DocumentElement;


                var t = ((ISMEVMessageExchangePortTypeClient)client).SendRequest(
                    senderProvidedRequestData,
                    null,
                    smevSing,
                    out _);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Good");
            Console.ReadKey();
        }

        private static X509Certificate2 x509Certificate2(string serialNumCert = "7cd0ab00feac16b04da7aa974b7d74ec")
        {
            X509Certificate2 _x509Certificate2;

            //X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            try
            {
                _x509Certificate2 = store.Certificates.Find(X509FindType.FindBySerialNumber, serialNumCert, true)[0];
            }
            catch
            {
                throw new Exception("Не найден сертификат с серийным номером " + serialNumCert);
            }
            finally
            {
                store.Close();
            }
            return _x509Certificate2;
        }
        
        private static SignatureType Signed(XmlDocument doc, X509Certificate2 certificate, string xmlReference)
        {
            SignedXml signedXml = new SignedXml(doc);

            signedXml.SigningKey = certificate.PrivateKey;

            //SignedInfo
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;
            signedXml.SignedInfo.SignatureMethod = CPSignedXml.XmlDsigGost3410_2012_256Url;

            //!Так же внести измененеия в структуру signature
            Reference reference = new Reference()
            {
                Uri = "#" + xmlReference,
                DigestMethod = CPSignedXml.XmlDsigGost3411_2012_256Url,
            };

            //reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
            reference.AddTransform(new XmlDsigExcC14NTransform());
            reference.AddTransform(new XmlDsigSmevTransform());

            signedXml.AddReference(reference);

            // Добавляем СМЭВ трансформ.
            // начиная с .NET 4.5.1 для проверки подписи, необходимо добавить этот трансформ в довернные:
            signedXml.SafeCanonicalizationMethods.Add("urn://smev-gov-ru/xmldsig/transform");


            signedXml.ComputeSignature();
            //return signedXml.GetXml();

            return new SignatureType()
            {
                SignedInfo = new SignedInfoType()
                {
                    CanonicalizationMethod = new CanonicalizationMethodType() { Algorithm = signedXml.SignedInfo.CanonicalizationMethod },
                    SignatureMethod = new SignatureMethodType() { Algorithm = signedXml.SignedInfo.SignatureMethod },
                    Reference = new ReferenceType1[] {
                                    new ReferenceType1() { URI = "#" + xmlReference,
                                    Transforms = new TransformType[] {
										//new TransformType() { Algorithm = new XmlDsigEnvelopedSignatureTransform().Algorithm },
										new TransformType() { Algorithm = new XmlDsigExcC14NTransform().Algorithm },
                                        new TransformType() { Algorithm = new XmlDsigSmevTransform().Algorithm }
                                    },
                                    DigestMethod = new DigestMethodType() { Algorithm = ((Reference)signedXml.SignedInfo.References[0]).DigestMethod },
                                    DigestValue = ((Reference)signedXml.SignedInfo.References[0]).DigestValue
                               }
                            }
                },
                SignatureValue = new SignatureValueType() { Value = signedXml.Signature.SignatureValue },
                KeyInfo = new KeyInfoType()
                {
                    ItemsElementName = new ItemsChoiceType2[] { ItemsChoiceType2.X509Data },
                    Items = new X509DataType[] {
                                new X509DataType() { ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.X509Certificate },
                                    Items = new object[] { certificate.RawData }
                                }
                            }
                }
                //Штамп времени
                //,Object = new ObjectType[] {
                //    new ObjectType() {

                //    }
                //}
            };
        }

        private static bool Verification(XmlDocument xmlDoc)
        {
            //Не проверяет более одной подписи в документе
            SignedXml signedXml = new SignedXml(xmlDoc);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Signature");
            bool valid = false;
            foreach (XmlElement element in nodeList)
            {
                XmlNodeList tagCertXML = element.GetElementsByTagName("X509Certificate");
                X509Certificate2 certXML = new X509Certificate2(Convert.FromBase64String(tagCertXML[0].InnerText));

                signedXml.LoadXml(element);
                valid = signedXml.CheckSignature(certXML, true);
            }
            return valid;
        }
    }
}
