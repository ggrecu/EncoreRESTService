using System.Xml.Serialization;

namespace Encore.REST.Model.Entities
{
    public abstract class EntityWithAccessInfo
    {

        [XmlElement("Created")]
        public string Created
        { get; set; }

        [XmlElement("CreatedBy")]
        public Person CreatedBy
        { get; set; }

        [XmlElement("Updated")]
        public string Updated
        { get; set; }

        [XmlElement("UpdatedBy")]
        public Person UpdatedBy
        { get; set; }



    }
}