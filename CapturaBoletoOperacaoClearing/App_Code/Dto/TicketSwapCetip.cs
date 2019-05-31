using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "TicketSwapCetip")]
    public class TicketSwapCetip
    {
        [DataMember]
        [XmlElement(ElementName = "swap-cetip")]
        public List<SwapCetip> SwapCetipList { get; set; }
    }
}