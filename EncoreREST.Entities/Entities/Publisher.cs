using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    [GeneratedCode("xsd", "4.0.30319.17929")]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Publisher : EntityWithAccessInfo
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string HasInternationalClearance
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string HasMechanicalRight
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string HasPerformanceRight
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string HasVideoRight
        { get; set; }



        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Split
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Territory
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string name
        { get; set; }


    }
}