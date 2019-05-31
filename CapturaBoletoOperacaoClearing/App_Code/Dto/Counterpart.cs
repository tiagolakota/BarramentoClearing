using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "counterpart")]
    public class Counterpart
    {
        [DataMember]
        [XmlElement(ElementName = "clearingAccount")]
        public string ClearingAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "command")]
        public string Command { get; set; }

        [DataMember]
        [XmlElement(ElementName = "document")]
        public string Document { get; set; }

        [DataMember]
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }
}