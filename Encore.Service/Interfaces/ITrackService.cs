using Encore.REST.Model.Entities;

namespace Encore.Service
{
    public interface ITrackService
    {
        Track GetTrack(int id);
        Track[] GetTracks(int limit);
        int GetTrackCount();
        Track[] ViewPublishedTracks();
        Track GetTrackByISRC(string code);
        Track[] ViewPendingTracks(int limitCount);
        bool Update(Track track, int queueid, string message, string status);

    }
}