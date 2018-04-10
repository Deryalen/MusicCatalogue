namespace MusicCatalogue.Model
{
    using System;
    public sealed class Artist : ModelBase
    {
        private Guid id = new Guid();

        private string name;

        private DateTime year;

        private SongsCollection songs;

        private AlbumsCollection albums;

        public Artist()
        {
            new Artist($"Sample Artist {Id}", DateTime.MinValue, new SongsCollection(), new AlbumsCollection());
        }

        public Artist(string name, DateTime year, SongsCollection songs, AlbumsCollection albums)
        {
            this.Name = name;
            this.Year = year;
            this.Songs = songs;
            this.Albums = albums;

            this.CreateTimeStamp = DateTime.Now;
            this.UpdateTimeStamp = DateTime.Now;
        }
        
        public Guid Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (this.id != value)
                {
                    this.id = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }

        public DateTime Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (this.year != value)
                {
                    this.year = value;
                }
            }
        }

        public SongsCollection Songs
        {
            get
            {
                return this.songs;
            }
            private set
            {
                if (this.songs != value)
                {
                    this.songs = value;
                }
            }
        }

        public AlbumsCollection Albums
        {
            get
            {
                return this.albums;
            }
            private set
            {
                if (this.albums != value)
                {
                    this.albums = value;
                }
            }
        }

        public ArtistsCollection GetArtists()
        {
            return FakeDatabase.GetAllArtists();
        }

        public Artist GetById(Guid id)
        {
            return FakeDatabase.GetArtistById(id);
        }

        public ArtistsCollection GetByName(string name)
        {
            return FakeDatabase.GetArtistsByName(name);
        }
    }
}
