using System.Xml.Schema;
using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    public abstract class  BaseEntity
    {

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Id
        { get; set; }


        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Name
        { get; set; }


    }
}