using System.Runtime.Serialization;

namespace SMEV3v13.DataContract
{
    [DataContract(Name = "QuoteLimitExceeded", Namespace = "urn://x-artefacts-smev-gov-ru/services/message-exchange/types/faults/1.3")]
    public class QuoteLimitExceeded : SmevFault
    {
        [DataMember(IsRequired = true)]
        public long RemainedTotalQuoteSize { get; set; }

        [DataMember(IsRequired = true, Order = 1)]
        public long RealTotalAttachmentSize { get; set; }
    }
}
