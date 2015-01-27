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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class PrimaryArtist: EntityWithAccessInfo
    {
        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Country
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Description
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DisplayName
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Guid
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsActive
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsGroup
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Name
        { get; set; }


    }
}