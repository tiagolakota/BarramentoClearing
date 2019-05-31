using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Dto
{
    [DataContract]
    [XmlRoot(ElementName = "contracted")]
    public class Contracted
    {
        [DataMember]
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "annotations")]
        public string Annotations { get; set; }

        [DataMember]
        [XmlElement(ElementName = "command")]
        public string Command { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartDocument")]
        public string CounterpartDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartName")]
        public string CounterpartName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "counterpartSelicAccount")]
        public string CounterpartSelicAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [DataMember]
        [XmlElement(ElementName = "issueTax")]
        public string IssueTax { get; set; }

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
        [XmlElement(ElementName = "portfolioCode")]
        public string PortfolioCode { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioDocument")]
        public string PortfolioDocument { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioName")]
        public string PortfolioName { get; set; }

        [DataMember]
        [XmlElement(ElementName = "portfolioSelicAccount")]
        public string PortfolioSelicAccount { get; set; }

        [DataMember]
        [XmlElement(ElementName = "returnDate")]
        public string ReturnDate { get; set; }

        [DataMember]
        [XmlElement(ElementName = "security")]
        public string Security { get; set; }

        [DataMember]
        [XmlElement(ElementName = "securityId")]
        public string SecurityId { get; set; }

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
        [XmlElement(ElementName = "unitPriceOutward")]
        public string UnitPriceOutward { get; set; }

        [DataMember]
        [XmlElement(ElementName = "unitPriceReturn")]
        public string UnitPriceReturn { get; set; }

        [DataMember]
        [XmlElement(ElementName = "valueOutward")]
        public string ValueOutward { get; set; }

        [DataMember]
        [XmlElement(ElementName = "valueReturn")]
        public string ValueReturn { get; set; }

        [DataMember]
        [XmlElement(ElementName = "workflowStartDate")]
        public string WorkflowStartDate { get; set; }
    }
}