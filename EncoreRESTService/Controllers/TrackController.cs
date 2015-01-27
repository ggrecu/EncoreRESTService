using System.Net;
using System.Net.Http;
using System.Web.Http;
using Encore.REST.Model.Entities;
using Encore.REST.Service.Serializers;
using Encore.Service;

namespace Encore.REST.Service.Controllers
{
    public class TrackController : ApiController
    {
        private ITrackService service;

        public TrackController()
        {
            service = new MockTrackervice();
        }


        [HttpGet]
        public int Count()
        {
            return service.GetTrackCount();
        }

        
        [HttpGet]
        public CustomJsonResult GetTrackByISRC(string id)
        {
            if (id == "1")
            {
                var resp = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Track not found ");
                throw new HttpResponseException(resp);
               
            }

            //return new JSONResult(service.GetTrackByISRC(id));
            var data = service.GetTrackByISRC(id);
            return  new CustomJsonResult(data);
            /*var jr = new JsonResult { Data = data, ContentType = "text/xml" };
            return jr;*/

        }

        [HttpGet]
        public Track GetTrackByISRCXML(string id)
        {
            if (id == "1")
            {
                var resp = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Track not found ");
                throw new HttpResponseException(resp);

            }

            //return new JSONResult(service.GetTrackByISRC(id));
            var data = service.GetTrackByISRC(id);
            return data;
            /*var jr = new JsonResult { Data = data, ContentType = "text/xml" };
            return jr;*/

        }

        [HttpPost]
        public void UpdateTrack(string id, UpdateMessage message)
        {
            return;
        }

        //public HttpResponseMessage PostProduct(Product item)
        //{
        //    item = repository.Add(item);
        //    var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);

        //    string uri = Url.Link("DefaultApi", new { id = item.Id });
        //    response.Headers.Location = new Uri(uri);
        //    return response;
        //}

    }
}
