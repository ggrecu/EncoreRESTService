using System;
using System.Linq;

namespace Encore.REST.Model.Entities.Mock
{
    public static class MockExtensions
    {


        public static EncodedAudioFile[] EncodedAudioFiles =
       {
           new EncodedAudioFile() {Location = @"C:\Folder1\a.mp3", Platform = "Unity"},
           new EncodedAudioFile() {Location = @"C:\Folder1\a.mp3", Platform = "MGP"},
           new EncodedAudioFile() {Location = @"C:\Folder1\b.mp3", Platform = "MGP"},
           new EncodedAudioFile() {Location = @"C:\Folder1\a.mp3", Platform = "Well"},

       };
        public static Genre[] Genres =
       {
           new Genre() {Id = "1",Name="Rock",ParentGenre = null},
           new Genre() {Id = "2",Name="Classic Rock",ParentGenre = null},
           new Genre() {Id = "3",Name="Pop",ParentGenre = null},
           new Genre() {Id = "4",Name="Classical",ParentGenre = null},
       };

        public static Label[] Labels =
       {
           new Label() {HasMasterRight = "1", HasVideoRight = "1", Id="1", LicensingEntity = "Emi",  Name = "Labelname 1", Territory = "Canada"}, 
           new Label() {HasMasterRight = "0", HasVideoRight = "0", Id="1", LicensingEntity = "SONY",  Name = "Labelname 2", Territory = "Canada"}, 
           new Label() {HasMasterRight = "1", HasVideoRight = "0", Id="1", LicensingEntity = "BMG",  Name = "Labelname 3", Territory = "Canada"}, 
           new Label() {HasMasterRight = "0", HasVideoRight = "1", Id="1", LicensingEntity = "Westside productions",  Name = "Labelname 4", Territory = "Canada"}, 
       };

        //Cb, Up, Publishers-[], Writers-[]
        public static MusicalWork[] MusicalWorks =
        {
            new MusicalWork()
            {
                CircleC = "CircleC1",
                Id = "1",
                HFACode = "HFACode1",
                Title = "Title1",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
               },
            new MusicalWork()
            {
                CircleC = "CircleC2",
                Id = "2",
                HFACode = "HFACode2",
                Title = "Title2",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
               },
            new MusicalWork()
            {
                CircleC = "CircleC3",
                Id = "3",
                HFACode = "HFACode3",
                Title = "Title3",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
               },
        };

        public static Person[] Persons =
        {
            new Person() {email = "Person1@email.com", Id = "1", Name = "John Doe1"}, 
            new Person() {email = "Person2@email.com", Id = "2", Name = "John Doe2"}, 
            new Person() {email = "Person3@email.com", Id = "3", Name = "John Doe3"}, 
            new Person() {email = "Person4@email.com", Id = "4", Name = "John Doe4"}, 

        };

        //Cb,Ub, Location
        public static PhysicalDisc[] PhysicalDiscs =
        {
            new PhysicalDisc()
            {
                CatelogNumber = "123", 
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                DiscNumber = "1", 
                Id = "1"                           
            }, 
            new PhysicalDisc()
            {
                CatelogNumber = "223", 
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                DiscNumber = "2", 
                Id = "2"                           
            }, 
            new PhysicalDisc()
            {
                CatelogNumber = "323", 
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                DiscNumber = "3", 
                Id = "3"                           
            }, 
            new PhysicalDisc()
            {
                CatelogNumber = "423", 
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                DiscNumber = "4", 
                Id = "4"                           
            }, 
        };

        //Cb,Ub, 
        public static PrimaryArtist[] PrimaryArtists =
        {
            new PrimaryArtist()
            {
                Country="Canada",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Description = "Artist1 Description",
                Guid = new Guid().ToString(),
                Id = "1", 
                DisplayName = "Artist 1 Displayname", 
                IsActive = "1", 
                IsGroup = "1", 
                Name = "Artist 1 Name"         
            }, 
            new PrimaryArtist()
            {
                Country="Canada",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Description = "Artist2 Description",
                Guid = new Guid().ToString(),
                Id = "2", 
                DisplayName = "Artist 2 Displayname", 
                IsActive = "1", 
                IsGroup = "0", 
                Name = "Artist 2 Name"         
            }, 
            new PrimaryArtist()
            {
                Country="USA",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Description = "Artist3 Description",
                Guid = new Guid().ToString(),
                Id = "3", 
                DisplayName = "Artist 3 Displayname", 
                IsActive = "1", 
                IsGroup = "0", 
                Name = "Artist 3 Name"         
            }, 
            new PrimaryArtist()
            {
                Country="Mexico",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Description = "Artist4 Description",
                Guid = new Guid().ToString(),
                Id = "4", 
                DisplayName = "Artist 4 Displayname", 
                IsActive = "1", 
                IsGroup = "0", 
                Name = "Artist 4 Name"         
            }, 
        };

        //Cb,Ub, 
        public static Publisher[] Publishers =
        {
            new Publisher() {Id ="1",
                HasInternationalClearance = "1",
                HasMechanicalRight = "1", 
                HasPerformanceRight = "1", 
                HasVideoRight = "1", 
                Split = "100", 
                Territory = "Teritory1", 
                name = "Publisher 1",                
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"), },
           new Publisher() {Id ="2",
                HasInternationalClearance = "2",
                HasMechanicalRight = "1", 
                HasPerformanceRight = "1", 
                HasVideoRight = "1", 
                Split = "100", 
                Territory = "Teritory2", 
                name = "Publisher 2",                
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"), },
           new Publisher() {Id ="3",
                HasInternationalClearance = "1",
                HasMechanicalRight = "1", 
                HasPerformanceRight = "1", 
                HasVideoRight = "0", 
                Split = "100", 
                Territory = "Teritory4", 
                name = "Publisher 4",                
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"), },
           new Publisher() {Id ="4",
                HasInternationalClearance = "1",
                HasMechanicalRight = "1", 
                HasPerformanceRight = "1", 
                HasVideoRight = "1", 
                Split = "100", 
                Territory = "Teritory4", 
                name = "Publisher 4",                
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"), }
        };

        //Cb, Ub, Rb, PrimaryArtist, Labels=[]
        public static Release[] Releases =
        {
            new Release()
            {
                CDDBID="CDDBID",
                CircleP = "CircleP1",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "1", IsActive = "1", 
                IsCompilation = "1",
                NumberOfTracks = "10", 
                DisplayTitle = "Display Title 1", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 1", 
               
            }, 
            new Release()
            {
                CDDBID="CDDBID",
                CircleP = "CircleP2",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "2", 
                IsActive = "1", 
                IsCompilation = "0",
                NumberOfTracks = "20", 
                DisplayTitle = "Display Title 2", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 2", 
               
            }, 
            new Release()
            {
                CDDBID="CDDBID",
                CircleP = "CircleP3",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "3", 
                IsActive = "0", 
                IsCompilation = "0",
                NumberOfTracks = "30", 
                DisplayTitle = "Display Title 3", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 3", 
               
            }, 
            new Release()
            {
                CDDBID="CDDBID",
                CircleP = "CircleP4",
                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "4",
                IsActive = "1", 
                IsCompilation = "1",
                NumberOfTracks = "40", 
                DisplayTitle = "Display Title 4", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 4", 
               
            }, 


        };


        public static Track[] Tracks =
        {
            new Track()
            {

                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "1", IsActive = "1", 
                BeatsPerMinute = "10", 
                DisplayTitle = "Display Title 1", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 1", 
                Duration = "130", 
                ISRC = "123456789", 
                IsInstrumental = "true", 
                TrackNumber = "1", 
                VocalGender = "Vocal Gender 1", 
                Year = "2001"              
            }, 
            new Track()
            {

                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "2", IsActive = "2", 
                BeatsPerMinute = "20", 
                DisplayTitle = "Display Title 2", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 2", 
                Duration = "230", 
                ISRC = "223456789", 
                IsInstrumental = "true", 
                TrackNumber = "2", 
                VocalGender = "Vocal Gender 2", 
                Year = "2002"              
            },
            new Track()
            {

                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "3", IsActive = "3", 
                BeatsPerMinute = "30", 
                DisplayTitle = "Display Title 3", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 3", 
                Duration = "330", 
                ISRC = "323456789", 
                IsInstrumental = "true", 
                TrackNumber = "3", 
                VocalGender = "Vocal Gender 3", 
                Year = "2001"              
            },
            new Track()
            {

                Created = DateTime.Now.ToString("g"),
                Updated = DateTime.Now.ToString("g"),
                Guid = new Guid().ToString(),
                Id = "4", IsActive = "4", 
                BeatsPerMinute = "40", 
                DisplayTitle = "Display Title 4", 
                Requested   = DateTime.Now.ToString("g"), 
                Title = "Title 4", 
                Duration = "430", 
                ISRC = "423456789", 
                IsInstrumental = "true", 
                TrackNumber = "4", 
                VocalGender = "Vocal Gender 4",  
                Year = "2004"              
            },  
        };


        public static Writer[] Writers =
        {
            new Writer()  { Id = "1", Name = "John Writer1"}, 
            new Writer()  { Id = "2", Name = "John Writer2"}, 
            new Writer()  { Id = "3", Name = "John Writer3"}, 
            new Writer()  { Id = "4", Name = "John Writer4"}, 
            new Writer()  { Id = "5", Name = "John Writer5"}, 
            new Writer()  { Id = "6", Name = "John Writer6"}, 

        };

        static MockExtensions()
        {
            Genres[1].ParentGenre = Genres[0];

            for (int i = 0; i < MusicalWorks.Length; i++)
            {
                MusicalWorks[i].CreatedBy = (new Person()).Mock();
                MusicalWorks[i].UpdatedBy = (new Person()).Mock();
                MusicalWorks[i].Writers = (new Writer[] { }).Mock();
                MusicalWorks[i].Publishers = (new Publisher[] { }).Mock();
            }

            for (int i = 0; i < PhysicalDiscs.Length; i++)
            {
                PhysicalDiscs[i].CreatedBy = (new Person()).Mock();
                PhysicalDiscs[i].UpdatedBy = (new Person()).Mock();
            }

            for (int i = 0; i < PrimaryArtists.Length; i++)
            {
                PrimaryArtists[i].CreatedBy = (new Person()).Mock();
                PrimaryArtists[i].UpdatedBy = (new Person()).Mock();
            }

            for (int i = 0; i < Releases.Length; i++)
            {
                Releases[i].CreatedBy = (new Person()).Mock();
                Releases[i].UpdatedBy = (new Person()).Mock();
                Releases[i].RequestedBy = (new Person()).Mock();
                Releases[i].Labels = (new Label[] { }).Mock();
                Releases[i].PrimaryArtist = (new PrimaryArtist()).Mock();
            }

            for (int i = 0; i < Tracks.Length; i++)
            {
                Tracks[i].CreatedBy = (new Person()).Mock();
                Tracks[i].UpdatedBy = (new Person()).Mock();
                Tracks[i].RequestedBy = (new Person()).Mock();
                Tracks[i].Release = (new Release()).Mock();
                Tracks[i].PrimaryArtist = (new PrimaryArtist()).Mock();
                Tracks[i].MusicalWork = (new MusicalWork()).Mock();
                Tracks[i].EncodedAudioFiles = (new EncodedAudioFile[] { }).Mock();
                Tracks[i].Genres = (new Genre[] { }).Mock();
                Tracks[i].PhysicalDisc = (new PhysicalDisc[] { }).Mock();
            }

            for (int i = 0; i < Publishers.Length; i++)
            {
                Publishers[i].CreatedBy = (new Person()).Mock();
                Publishers[i].UpdatedBy = (new Person()).Mock();
            }
        }

        public static EncodedAudioFile[] Mock(this EncodedAudioFile[] instanceEncodedAudioFile)
        {
            instanceEncodedAudioFile = GetManyFromCollection(EncodedAudioFiles);
            return instanceEncodedAudioFile;
        }


        public static Genre[] Mock(this  Genre[] instanceGenre)
        {
            
            instanceGenre = GetManyFromCollection(Genres);
            return instanceGenre;
        }

        public static Label Mock(this Label instanceLabel)
        {
            instanceLabel = GetOneFromCollection(Labels);
            return instanceLabel;
        }
        public static Label[] Mock(this Label[] instanceLabel)
        {
            instanceLabel = GetManyFromCollection(Labels);
            return instanceLabel;
        }

        public static MusicalWork Mock(this  MusicalWork instanceGenre)
        {

            instanceGenre = GetOneFromCollection(MusicalWorks);
            return instanceGenre;
        }

        public static Person Mock(this Person instancePerson)
        {
            instancePerson = GetOneFromCollection(Persons);
            return instancePerson;
        }

        public static PhysicalDisc[] Mock(this PhysicalDisc[] instancePhysicalDisc)
        {

            instancePhysicalDisc = GetManyFromCollection(PhysicalDiscs);
            return instancePhysicalDisc;
        }

        public static PrimaryArtist Mock(this PrimaryArtist instancePrimaryArtist)
        {

            instancePrimaryArtist = GetOneFromCollection(PrimaryArtists);
            return instancePrimaryArtist;
        }

        public static Release Mock(this Release instanceRelease)
        {

            instanceRelease = GetOneFromCollection(Releases);
            return instanceRelease;
        }


        public static Track Mock(this Track instanceTrack)
        {

            instanceTrack = GetOneFromCollection(Tracks);
            return instanceTrack;
        }


        public static Writer[] Mock(this Writer[] instanceWriter)
        {
            instanceWriter = GetManyFromCollection(Writers);
            return instanceWriter;
        }

        public static Publisher[] Mock(this Publisher[] instancePublisher)
        {

            instancePublisher = GetManyFromCollection(Publishers);
            return instancePublisher;
        }

        public static T GetOneFromCollection<T>(T[] myarray)
        {
            var r = new Random(DateTime.Now.Millisecond % int.MaxValue);
            return myarray[r.Next(myarray.Length)];
        }
        public static T[] GetManyFromCollection<T>(T[] myarray)
        {
            var r = new Random(DateTime.Now.Millisecond % int.MaxValue);
            var list = myarray.ToList();
            var need = r.Next(myarray.Length);
            for (int i = 0; i < need; i++)
            {
                list.RemoveAt(r.Next(list.Count));
            }
            return list.ToArray();
        }
    }
}
