using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketFundQuotas")]
    public class TicketFundQuotas
    {
        [DataMember]
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "Quota")]
        public List<Quota> QuotaList { get; set; }
    }
}