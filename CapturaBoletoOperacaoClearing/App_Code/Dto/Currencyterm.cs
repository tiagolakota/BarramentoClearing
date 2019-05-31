using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "currency-term")]
    public class Currencyterm
    {
        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "cetipSettlement")]
        public string CetipSettlement { get; set; }

        [DataMember]
        [XmlElement(ElementName = "contractNumber")]
        public string ContractNumber { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpart")]
        public Counterpart Counterpart { get; set; }

        [DataMember]
        [XmlElement(ElementName = "crossRate")]
        public string CrossRate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "currencyId")]
        public string CurrencyId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "futureFee")]
        public string FutureFee { get; set; }

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
        [XmlElement(ElementName = "operationValue")]
        public string OperationValue { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolio")]
        public Portfolio Portfolio { get; set; }

        [DataMember]
        [XmlElement(ElementName = "quoteExpirationTypeId")]
        public string QuoteExpirationTypeId { get; set; }

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
        [XmlElement(ElementName = "workflowId")]
        public string WorkflowId { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}