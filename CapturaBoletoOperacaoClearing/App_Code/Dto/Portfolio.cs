using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "portfolio")]
    public class Portfolio
    {
        [DataMember]
        [XmlElement(ElementName = "account")]
        public string Account { get; set; }

        [DataMember]
        [XmlElement(ElementName = "clearingAccount")]
        public string ClearingAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [DataMember]
        [XmlElement(ElementName = "document")]
        public string Document { get; set; }

        [DataMember]
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }
}