using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "futures")]
    public class Futures
    {
        [DataMember]
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "broker")]
        public string Broker { get; set; }

        [DataMember]
        [XmlElement(ElementName = "brokerAccount")]
        public string BrokerAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "brokerCode")]
        public string BrokerCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "brokerDocument")]
        public string BrokerDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationDate")]
        public string OperationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "operationTypeId")]
        public string OperationTypeId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "paperCode")]
        public string PaperCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "paperSerie")]
        public string PaperSerie { get; set; }

        [DataMember]
        [XmlElement(ElementName = "percentageDiscount")]
        public string PercentageDiscount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioAccount")]
        public string PortfolioAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioB3Account")]
        public string PortfolioB3Account { get; set; }

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
        [XmlElement(ElementName = "tradingDate")]
        public string TradingDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "unitPrice")]
        public string UnitPrice { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}