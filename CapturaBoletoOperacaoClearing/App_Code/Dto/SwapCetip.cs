using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "SwapCetip")]
    public class SwapCetip
    {
        [DataMember]
        [XmlElement(ElementName = "activeIndex")]
        public string ActiveIndex { get; set; }

        [DataMember]
        [XmlElement(ElementName = "activeIndexBase")]
        public string ActiveIndexBase { get; set; }

        [DataMember]
        [XmlElement(ElementName = "activeIndexPercent")]
        public string ActiveIndexPercent { get; set; }

        [DataMember]
        [XmlElement(ElementName = "activeIndexTax")]
        public string ActiveIndexTax { get; set; }

        [DataMember]
        [XmlElement(ElementName = "activeInterestType")]
        public string ActiveInterestType { get; set; }

        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "command")]
        public string Command { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartCetipAccount")]
        public string CounterpartCetipAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartDocument")]
        public string CounterpartDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartName")]
        public string CounterpartName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationDate")]
        public string OperationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationValue")]
        public string OperationValue { get; set; }

        [DataMember]
        [XmlElement(ElementName = "passiveIndex")]
        public string PassiveIndex { get; set; }

        [DataMember]
        [XmlElement(ElementName = "passiveIndexBase")]
        public string PassiveIndexBase { get; set; }

        [DataMember]
        [XmlElement(ElementName = "passiveIndexPercent")]
        public string PassiveIndexPercent { get; set; }

        [DataMember]
        [XmlElement(ElementName = "passiveIndexTax")]
        public string PassiveIndexTax { get; set; }

        [DataMember]
        [XmlElement(ElementName = "passiveInterestType")]
        public string PassiveInterestType { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioAccount")]
        public string PortfolioAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioCetipAccount")]
        public string PortfolioCetipAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioCode")]
        public string PortfolioCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioDocument")]
        public string PortfolioDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioName")]
        public string PortfolioName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "statusDescription")]
        public string StatusDescription { get; set; }

        [DataMember]
        [XmlElement(ElementName = "statusId")]
        public string StatusId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "statusRequiredRoles")]
        public StatusRequiredRoles StatusRequiredRoles { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}