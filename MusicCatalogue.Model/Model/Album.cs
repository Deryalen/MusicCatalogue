namespace MusicCatalogue.Model
{
    using System;

    public sealed class Album : ModelBase
    {
        private Guid id = new Guid();

        private string name;

        private DateTime publishmentDate;

        private SongsCollection songs;

        public Album()
        {
            new Album($"Sample Album {Id}", DateTime.MinValue, new SongsCollection());
        }

        public Album(string name, DateTime publishmentDate, SongsCollection songs)
        {
            this.Name = name;
            this.PublishmentDate = publishmentDate;
            this.Songs = songs;

            this.CreateTimeStamp = DateTime.Now;
            this.UpdateTimeStamp = DateTime.Now;
        }

        public Guid Id
        {
            get
            {
                return this.id;
            }
            set
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
                return name;
            }
            set
            {
                if (this.name != value && !String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        public SongsCollection Songs
        {
            get
            {
                return this.songs;
            }
            set
            {
                if (this.songs != value)
                {
                    this.songs = value;
                }
            }
        }

        public DateTime PublishmentDate
        {
            get
            {
                return this.publishmentDate;
            }
            set
            {
                if (this.publishmentDate != value && value < DateTime.Today)
                {
                    this.publishmentDate = value;
                }
            }
        }

        public AlbumsCollection GetAlbums()
        {
            return FakeDatabase.GetAllAlbums();
        }

        public Album GetById(Guid id)
        {
            return FakeDatabase.GetAlbumById(id);
        }

        public AlbumsCollection GetByName(string name)
        {
            return FakeDatabase.GetAlbumsByName(name);
        }
    }
}