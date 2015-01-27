using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class MusicalWork : EntityWithAccessInfo
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CircleC { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string HFACode
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Title
        { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Publisher", typeof(Publisher), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
        public Publisher[] Publishers
        { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("element", typeof(Writer), IsNullable = false)]
        public Writer[] Writers
        { get; set; }
    }
}