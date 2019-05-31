using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketCurrencyTerm")]
    public class TicketCurrencyTerm
    {
        [DataMember]
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "currency-term")]
        public List<Currencyterm> CurrencytermList { get; set; }
    }
}