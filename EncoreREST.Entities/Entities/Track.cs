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
    public class Track : EntityWithAccessInfo
    {

        [XmlElement("BeatsPerMinute")]
        public string BeatsPerMinute
        { get; set; }

        [XmlElement("RequestedBy")]
        public Person RequestedBy
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DisplayTitle
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Duration
        { get; set; }

        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("element", typeof(Genre), IsNullable = false)]
        public Genre[] Genres
        { get; set; }


        [XmlArray(Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("element", typeof(EncodedAudioFile), IsNullable = false)]
        public EncodedAudioFile[] EncodedAudioFiles
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Guid
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ISRC
        { get; set; }


        [XmlElement("Id")]
        public string Id
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsActive
        { get; set; }

        [XmlElement("MusicalWork")]
        public MusicalWork MusicalWork
        { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IsInstrumental
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Requested
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Title
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TrackNumber
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string VocalGender
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Year
        { get; set; }


        [XmlElement("PrimaryArtist")]
        public PrimaryArtist PrimaryArtist
        { get; set; }

        [XmlElement("PhysicalDisc", Form = XmlSchemaForm.Unqualified)]
        public PhysicalDisc[] PhysicalDisc
        { get; set; }


        [XmlElement("Release")]
        public Release Release
        { get; set; }

       
    }
}