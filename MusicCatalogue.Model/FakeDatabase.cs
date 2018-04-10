namespace MusicCatalogue.Model
{
    using System;
    using System.Linq;

    public static class FakeDatabase
    {
        private static ArtistsCollection artists;

        private static SongsCollection songs;

        private static AlbumsCollection albums;

        public static ArtistsCollection GetAllArtists()
        {
            return artists;
        }

        public static Artist GetArtistById(Guid id)
        {
            return artists.FirstOrDefault(a => a.Id == id);
        }

        public static ArtistsCollection GetArtistsByName(string name)
        {
            var result = new ArtistsCollection();
            artists.Where(a => a.Name == name).ToList().ForEach(result.Add);
            return result;
        }

        public static SongsCollection GetAllSongs()
        {
            return songs;
        }

        public static Song GetSongById(Guid id)
        {
            return songs.FirstOrDefault(s => s.Id == id);
        }

        public static SongsCollection GetSongsByName(string name)
        {
            var result = new SongsCollection();
            songs.Where(s => s.Name == name).ToList().ForEach(result.Add);
            return result;
        }

        public static AlbumsCollection GetAllAlbums()
        {
            return albums;
        }

        public static Album GetAlbumById(Guid id)
        {
            return albums.FirstOrDefault(a => a.Id == id);
        }

        public static AlbumsCollection GetAlbumsByName(string name)
        {
            var result = new AlbumsCollection();
            albums.Where(a => a.Name == name).ToList().ForEach(result.Add);
            return result;
        }

        public static void PopulateDatabase()
        {
            for (int i = 0; i < 100; i++)
            {
                songs.Add(new Song());
                albums.Add(new Album());
                artists.Add(new Artist());
            }
        }
    }
}
