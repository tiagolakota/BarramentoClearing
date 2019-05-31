using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketReject")]
    public class TicketReject
    {
        [DataMember]
        [XmlElement(ElementName = "ReturnOk")]
        public bool ReturnOk { get; set; }

        [DataMember]
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "Content")]
        public string Content { get; set; }
    }
}