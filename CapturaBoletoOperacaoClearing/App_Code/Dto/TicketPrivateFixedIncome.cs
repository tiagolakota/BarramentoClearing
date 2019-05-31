using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketPrivateFixedIncome")]
    public class TicketPrivateFixedIncome
    {
        [DataMember]
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "private-fixed-income")]
        public List<Privatefixedincome> PrivatefixedincomeList { get; set; }
    }
}