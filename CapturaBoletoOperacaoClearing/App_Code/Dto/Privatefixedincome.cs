using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "private-fixed-income")]
    public class Privatefixedincome
    {
        [DataMember]
        [XmlElement(ElementName = "acquisitionDate")]
        public string AcquisitionDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "assetCode")]
        public string AssetCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "assetType")]
        public string AssetType { get; set; }

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
        [XmlElement(ElementName = "isSecondaryMarket")]
        public string IsSecondaryMarket { get; set; }

        [DataMember]
        [XmlElement(ElementName = "isTerm")]
        public string IsTerm { get; set; }

        [DataMember]
        [XmlElement(ElementName = "issueDate")]
        public string IssueDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "issueFee")]
        public string IssueFee { get; set; }

        [DataMember]
        [XmlElement(ElementName = "objectAction")]
        public string ObjectAction { get; set; }

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
        [XmlElement(ElementName = "unitPrice")]
        public string UnitPrice { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}