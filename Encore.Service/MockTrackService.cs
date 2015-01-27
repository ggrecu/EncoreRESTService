using System;
using System.Collections.Generic;
using System.Linq;
using Encore.REST.Model.Entities;
using Encore.REST.Model.Entities.Mock;

namespace Encore.Service
{
    public class MockTrackervice : ITrackService
    {
        public Track GetTrack(int id)
        {
            return  new Track { Id = id.ToString(), 
                                Created = DateTime.Now.ToString("O") 
            };
        }

        public int GetTrackCount()
        {
            return DateTime.Now.Second;
        }

        public Track[] GetTracks(int limit)
        {
            var tracks = new List<Track>();
            for (int i = 0; i < limit; i++)
                tracks.Add(GetTrack(i).Mock());
            return tracks.ToArray();
        }


        public Track[] ViewPublishedTracks()
        {
            throw new NotImplementedException();
        }

        public Track GetTrackByISRC(string code)
        {
            var t = new Track();
            return t.Mock();
        }

        public Track[] ViewPendingTracks(int limitCount)
        {
            var track = (new Track()).Mock();
            var trackArray  = MockExtensions.GetManyFromCollection(MockExtensions.Tracks).Take(limitCount).ToArray();
            return trackArray;
        }

        public bool Update(Track track, int queueid, string message, string status)
        {
            throw new NotImplementedException();
        }
    }
}
