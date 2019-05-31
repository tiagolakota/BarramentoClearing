using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "Quota")]
    public class Quota
    {
        [DataMember]
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [XmlElement(ElementName = "annotations")]
        [DataMember]
        public string Annotations { get; set; }

        [XmlElement(ElementName = "command")]
        [DataMember]
        public string Command { get; set; }

        [XmlElement(ElementName = "counterpartCetipAccount")]
        [DataMember]
        public string CounterpartCetipAccount { get; set; }

        [XmlElement(ElementName = "counterpartDocument")]
        [DataMember]
        public string CounterpartDocument { get; set; }

        [XmlElement(ElementName = "counterpartName")]
        [DataMember]
        public string CounterpartName { get; set; }

        [XmlElement(ElementName = "fullRedeem")]
        [DataMember]
        public string FullRedeem { get; set; }

        [XmlElement(ElementName = "fundAccount")]
        [DataMember]
        public string FundAccount { get; set; }

        [XmlElement(ElementName = "fundBank")]
        [DataMember]
        public string FundBank { get; set; }

        [XmlElement(ElementName = "fundBranch")]
        [DataMember]
        public string FundBranch { get; set; }

        [XmlElement(ElementName = "fundClassSeries")]
        [DataMember]
        public string FundClassSeries { get; set; }

        [XmlElement(ElementName = "fundDocument")]
        [DataMember]
        public string FundDocument { get; set; }

        [XmlElement(ElementName = "fundName")]
        [DataMember]
        public string FundName { get; set; }

        [XmlElement(ElementName = "fundType")]
        [DataMember]
        public string FundType { get; set; }

        [XmlElement(ElementName = "hasSameOwnership")]
        [DataMember]
        public string HasSameOwnership { get; set; }

        [XmlElement(ElementName = "id")]
        [DataMember]
        public string Id { get; set; }

        [XmlElement(ElementName = "isCetipVoice")]
        [DataMember]
        public string IsCetipVoice { get; set; }

        [XmlElement(ElementName = "isFIDC")]
        [DataMember]
        public string IsFidc { get; set; }

        [XmlElement(ElementName = "isIssueUnitPrice")]
        [DataMember]
        public string IsIssueUnitPrice { get; set; }

        [XmlElement(ElementName = "isNewFund")]
        [DataMember]
        public string IsNewFund { get; set; }

        [XmlElement(ElementName = "isSecondaryMarket")]
        [DataMember]
        public string IsSecondaryMarket { get; set; }

        [XmlElement(ElementName = "issuerName")]
        [DataMember]
        public string IssuerName { get; set; }

        [XmlElement(ElementName = "mnemonicCode")]
        [DataMember]
        public string MnemonicCode { get; set; }

        [XmlElement(ElementName = "operationDate")]
        [DataMember]
        public string OperationDate { get; set; }

        [XmlElement(ElementName = "operationTypeId")]
        [DataMember]
        public string OperationTypeId { get; set; }

        [XmlElement(ElementName = "operationValue")]
        [DataMember]
        public string OperationValue { get; set; }

        [XmlElement(ElementName = "portfolioAccount")]
        [DataMember]
        public string PortfolioAccount { get; set; }

        [XmlElement(ElementName = "portfolioCetipAccount")]
        [DataMember]
        public string PortfolioCetipAccount { get; set; }

        [XmlElement(ElementName = "portfolioCode")]
        [DataMember]
        public string PortfolioCode { get; set; }

        [XmlElement(ElementName = "portfolioDocument")]
        [DataMember]
        public string PortfolioDocument { get; set; }

        [XmlElement(ElementName = "portfolioName")]
        [DataMember]
        public string PortfolioName { get; set; }

        [XmlElement(ElementName = "quotaValue")]
        [DataMember]
        public string QuotaValue { get; set; }

        [XmlElement(ElementName = "settlementTypeId")]
        [DataMember]
        public string SettlementTypeId { get; set; }

        [XmlElement(ElementName = "statusDescription")]
        [DataMember]
        public string StatusDescription { get; set; }

        [XmlElement(ElementName = "statusId")]
        [DataMember]
        public string StatusId { get; set; }

        [XmlElement(ElementName = "workflowStartDate")]
        [DataMember]
        public string WorkflowStartDate { get; set; }
    }
}