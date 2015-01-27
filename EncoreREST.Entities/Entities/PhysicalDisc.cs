using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class PhysicalDisc : EntityWithAccessInfo
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CatelogNumber
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DiscNumber
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Location
        { get; set; }

    }
}