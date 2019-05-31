using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketFutures")]
    public class TicketFutures
    {
        [DataMember]
        [XmlElement(ElementName = "futures")]
        public List<Futures> FuturesList { get; set; }
    }
}