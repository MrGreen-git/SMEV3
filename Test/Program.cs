using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using CryptoPro.Sharpei.Xml;
using GisGmp;
using GisGmp.SearchConditions;
using SMEV3v12;
using SMEV3v12.Types;
using SMEV3v12.Types.Basic;

namespace Test
{
    class Program
    {
        static ISMEVMessageExchangePortTypeClient client  = new SMEVMessageExchangePortTypeClient();

        static void Main(string[] args)
        {
            (client as SMEVMessageExchangePortTypeClient).Endpoint.Behaviors.Add(new InspectorBehavior());

            try
            {
                var request = Request();
                Console.WriteLine(request?.MessageId);

                var response = Response();
                Console.WriteLine(response?.Response.OriginalMessageId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }

        private static MessageMetadata Request()
        {
            //Настройка ГИС ГМП
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_a108e1f7-e0f0-48d2-8e80-b64a423efe4e",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb646",
                SenderRole = "9",

                PageNumber = 1,
                PageLength = 100
            };

            //Запрос ГИС ГМП
            var requestGisGmp = gisgmp.CreateExportPaymentsRequest(
                paymentsKind: ExportPaymentsKind.PAYMENT,
                uin: new SupplierBillIDType[] { new SupplierBillIDType("32117072411021588933") }
                );
            var xmlRequestGisGmp = GisGmpBuilder.SerializerObject(requestGisGmp, true);

            var signPersonal = Signed(xmlRequestGisGmp, x509Certificate2(), requestGisGmp.Id);
            var xmlSignPersonal = GisGmpBuilder.SerializerObject(signPersonal);

            //СМЭВ
            SenderProvidedRequestData senderProvidedRequestData = new SenderProvidedRequestData()
            {
                Id = "SMEV",//"C_" + Guid.NewGuid().ToString(),
                MessageID = GuidGenerator.GenerateTimeBasedGuid().ToString(),
                MessagePrimaryContent = xmlRequestGisGmp.DocumentElement,
                TestMessage = new SMEV3v12.Types.Basic.Void(),
                PersonalSignature = xmlSignPersonal.DocumentElement
            };
            var xmlSenderProvidedRequestData = GisGmpBuilder.SerializerObject(senderProvidedRequestData);

            //Проверить ЭП-СП
            var valid = Verification(GisGmpBuilder.SerializerObject(senderProvidedRequestData));


            var smevSign = Signed(xmlSenderProvidedRequestData, x509Certificate2(), senderProvidedRequestData.Id);
            var xmlSmevSign = GisGmpBuilder.SerializerObject(smevSign);

            return client.SendRequest(
                    senderProvidedRequestData,
                    null,
                    xmlSmevSign.DocumentElement,
                    out _);
        }

        private static SmevAsyncProcessingMessage Status()
        {
            var timeStamp = new Timestamp() { 
                Id = "SMEV", 
                Value = DateTime.Now 
            };
            var xmlTimeStamp = GisGmpBuilder.SerializerObject(timeStamp);

            var smevSign = Signed(xmlTimeStamp, x509Certificate2(), timeStamp.Id);
            var xmlSignSMEV = GisGmpBuilder.SerializerObject(smevSign);

            return client.GetStatus(
                timeStamp, 
                xmlSignSMEV.DocumentElement
                );        
        }

        private static GetResponseResponseResponseMessage Response()
        {
            var messageTypeSelector = new MessageTypeSelector()
            {
                Id = "I"+Guid.NewGuid().ToString(),
                Timestamp = DateTime.Now,
                RootElementLocalName = "ExportPaymentsRequest",
                NamespaceURI = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0",
                //NodeID = ""
            };

            var xmlMessageTypeSelector = GisGmpBuilder.SerializerObject(messageTypeSelector);

            var singSMEV = Signed(xmlMessageTypeSelector, x509Certificate2(), messageTypeSelector.Id);
            var xmlSingSMEV = GisGmpBuilder.SerializerObject(singSMEV);

            return client.GetResponse(
                messageTypeSelector, 
                xmlSingSMEV.DocumentElement
                );              
        }

        private static void Ask(string messageId)
        {
            AckTargetMessage ackTargetMessage = new AckTargetMessage() { 
                Id = "Ack", 
                acceptedSpecified = true, 
                accepted = true, 
                Value = messageId 
            };
            var xmlAckTargetMessage = GisGmpBuilder.SerializerObject(ackTargetMessage);
            
            var signSMEV = Signed(xmlAckTargetMessage, x509Certificate2(), ackTargetMessage.Id);
            var xmlSignSMEV = GisGmpBuilder.SerializerObject(signSMEV);

            client.Ack(
                ackTargetMessage, 
                xmlSignSMEV.DocumentElement
                );
        }

        #region Вспомогательные методы
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
        #endregion
    }
}
