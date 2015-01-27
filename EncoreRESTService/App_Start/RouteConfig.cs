using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace EncoreRESTService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            const string rootPath = "api/v1/";
            const string serializeMode = "JSON";

            routes.MapHttpRoute("Count", rootPath + "tracks/publishedtracks", new { controller = "Track", action = "Count" });
            routes.MapHttpRoute("GetTrackByISRC", rootPath + "track/{id}", new { controller = "Track", action = "GetTrackByISRC", id=RouteParameter.Optional });
            routes.MapHttpRoute("GetTrackByISRCXML", rootPath + "track/xml/{id}", new { controller = "Track", action = "GetTrackByISRCXML", id = RouteParameter.Optional });
            routes.MapHttpRoute("UpdateTrack", rootPath + "track/update/{id}", new { controller = "Track", action = "UpdateTrack", id = RouteParameter.Optional });

  //          routes.MapHttpRoute(
  //               name: "UpdateStatus",
  //               routeTemplate: rootPath + "playlist/updatestatus",
  //               defaults: new { controller = "Track", action = "UpdateStatus" }
  //           );

  //          routes.MapHttpRoute(
  //               name: "UpdatePriority",
  //               routeTemplate: rootPath + "playlist/updatepriority",
  //               defaults: new { controller = "Playlist", action = "UpdatePriority" }
  //           );

  //          routes.MapHttpRoute(
  //              name: "GetAllPlaylists",
  //              routeTemplate: rootPath + "playlist",
  //              defaults: new { controller = "Playlist", action = "GetAllPlaylists" }
  //          );

  //          routes.MapHttpRoute(
  //               name: "GetPlaylistsByDateRange",
  //               routeTemplate: rootPath + "playlist/datetimefilter",
  //               defaults: new { controller = "Playlist", action = "GetPlaylistsByDateRange" }
  //           );

  //          // this route is used by MGP application
  //          routes.MapHttpRoute(
  //                name: "ViewTracks",
  //                routeTemplate: rootPath + "track/list/{count}",
  //                defaults: new { controller = "Track", action = "GetTracks" + serializeMode, count = RouteParameter.Optional }
  //            );
  //          routes.MapHttpRoute(
  //              name: "ViewTrack",
  //              routeTemplate: rootPath + "track/{id}",
  //              defaults: new { controller = "Track", action = "GetTrack"+serializeMode, id = RouteParameter.Optional }
  //);
  
  //          // this route is used by: 
  //          // [POST] GetPlaylist(Guid id)
  //          // [GET] ViewPlaylist(Guid id, bool onlySummary = false) 
  //          //  and PlaylistExportClient library
  //          routes.MapHttpRoute(
  //              name: "ViewPlaylist",
  //              routeTemplate: rootPath + "playlist/{id}",
  //              defaults: new { controller = "Playlist", id = RouteParameter.Optional }
  //          );

  //          routes.MapRoute(
  //              name: "Default",
  //              url: "{controller}/{action}/{id}",
  //              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
  //          );
        }
    }
}