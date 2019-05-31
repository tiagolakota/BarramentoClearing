using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "margin")]
    public class Margin
    {
        [DataMember]
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "asset")]
        public string Asset { get; set; }

        [DataMember]
        [XmlElement(ElementName = "command")]
        public string Command { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartBrokerAccount")]
        public string CounterpartBrokerAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartClearingAccount")]
        public string CounterpartClearingAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartDocument")]
        public string CounterpartDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartName")]
        public string CounterpartName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "dueDate")]
        public string DueDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [DataMember]
        [XmlElement(ElementName = "marketTypeId")]
        public string MarketTypeId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationDate")]
        public string OperationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationTypeId")]
        public string OperationTypeId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationValue")]
        public string OperationValue { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioAccount")]
        public string PortfolioAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioClearingAccount")]
        public string PortfolioClearingAccount { get; set; }

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
        [XmlElement(ElementName = "purchaseDate")]
        public string PurchaseDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "quotation")]
        public string Quotation { get; set; }

        [DataMember]
        [XmlElement(ElementName = "securityCode")]
        public string SecurityCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "securityName")]
        public string SecurityName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "securityType")]
        public string SecurityType { get; set; }

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
        [XmlElement(ElementName = "unitPrice")]
        public string UnitPrice { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}