using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketAdvanceStep")]
    public class TicketAdvanceStep
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