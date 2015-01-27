using System.Web.Mvc;
using Newtonsoft.Json;

namespace Encore.REST.Service.Serializers
{
    // ReSharper disable once InconsistentNaming
    public class CustomJsonResult : ActionResult
    {
        private readonly object _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomJsonResult"/> class.
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize to XML.</param>
        public CustomJsonResult(object objectToSerialize)
        {
            _data = objectToSerialize;
        }

        /// <summary>
        /// Gets the object to be serialized to XML.
        /// </summary>
        public object Track
        {
            get { return _data; }
        }

        /// <summary>
        /// Serialises the object that was passed into the constructor to XML and writes the corresponding XML to the result stream.
        /// </summary>
        /// <param name="context">The controller context for the current request.</param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (_data != null)
            {
                // context.HttpContext.Response.Clear();

                context.HttpContext.Response.ContentType = "text/xml";
                var x = new JsonSerializer();
                x.Serialize(context.HttpContext.Response.Output, x);

                //' serializer.
            }
        }
    }
}