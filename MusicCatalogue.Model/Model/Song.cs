namespace MusicCatalogue.Model
{
    using System;

    public sealed class Song : ModelBase
    {
        private Guid id = new Guid();
        
        private string name;

        private DateTime publishmentDate;

        public Song()
        {
            new Song($"Sample Song {Id}", DateTime.MinValue);
        }

        public Song(string name, DateTime publishmentDate)
        {
            this.Name = name;
            this.PublishmentDate = publishmentDate;

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

        public DateTime PublishmentDate
        {
            get
            {
                return this.publishmentDate;
            }
            set
            {
                if (this.publishmentDate != value && value < DateTime.Now)
                {
                    this.publishmentDate = value;
                }
            }
        }

        public SongsCollection GetSongs()
        {
            return FakeDatabase.GetAllSongs();
        }

        public Song GetById(Guid id)
        {
            return FakeDatabase.GetSongById(id);
        }

        public SongsCollection GetByName(string name)
        {
            return FakeDatabase.GetSongsByName(name);
        }
    }
}