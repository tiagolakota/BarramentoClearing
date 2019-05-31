using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    /// <summary>
    ///     Descrição resumida de StatusRequiredRoles
    /// </summary>
    [DataContract]
    [XmlRoot(ElementName = "statusRequiredRoles")]
    public class StatusRequiredRoles
    {
        [DataMember]
        [XmlElement(ElementName = "private-fixed-income")]
        public string Privatefixedincome { get; set; }

        [DataMember]
        [XmlElement(ElementName = "public-fixed-income")]
        public string Publicfixedincome { get; set; }

        [DataMember]
        [XmlElement(ElementName = "currency-term")]
        public string Currencyterm { get; set; }

        [DataMember]
        [XmlElement(ElementName = "contracted")]
        public string Contracted { get; set; }

        [DataMember]
        [XmlElement(ElementName = "swap-cetip")]
        public string Swapcetip { get; set; }

        [DataMember]
        [XmlElement(ElementName = "futures")]
        public string Futures { get; set; }

        [DataMember]
        [XmlElement(ElementName = "margin")]
        public string Margin { get; set; }
    }
}