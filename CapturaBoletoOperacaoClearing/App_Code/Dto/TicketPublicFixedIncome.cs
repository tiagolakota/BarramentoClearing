using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketPublicFixedIncome")]
    public class TicketPublicFixedIncome
    {
        [DataMember]
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "public-fixed-income")]
        public List<Publicfixedincome> PublicfixedincomeList { get; set; }
    }
}