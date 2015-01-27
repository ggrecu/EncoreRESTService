using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Release : EntityWithAccessInfo
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CDDBID
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CircleP
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DisplayTitle
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Guid
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsActive
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsCompilation
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NumberOfTracks
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Requested
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Title
        { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("element", typeof(Label), IsNullable = false)]
        public Label[] Labels
        { get; set; }

        [XmlElement("PrimaryArtist")]
        public PrimaryArtist PrimaryArtist
        { get; set; }

        [XmlElement("RequestedBy")]
        public Person RequestedBy
        { get; set; }

    }
}