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
    public class Genre : BaseEntity
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified, IsNullable = true)]
        public Genre ParentGenre
        { get; set; }
    }
}