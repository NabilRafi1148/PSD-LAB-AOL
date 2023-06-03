using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;
using AOL_Code_1.Factory;

namespace AOL_Code_1.Repository
{
    public class ArtistRepository
    {
        Database1Entities db = new Database1Entities();

        public void addArtist(string ArtistName, string ArtistImage)
        {
            db.Artists.Add(ArtistFactory.createArtist(ArtistName, ArtistImage));
            db.SaveChanges();   
        }

        public void deleteArtist(int ArtistID)
        {
            Artist artist = db.Artists.Where(x => x.ArtistID == ArtistID).FirstOrDefault();

            db.Artists.Remove(artist);
            db.SaveChanges();
        }

        public void updateArtist(int ArtistID, string ArtistName, string ArtistImage)
        {
            Artist artist = db.Artists.Where(x => x.ArtistID == ArtistID).FirstOrDefault();

            artist.ArtistName = ArtistName;
            artist.ArtistImage = ArtistImage;
            db.SaveChanges();
        }

        public Artist GetArtist(string artistname)
        {
            Artist artistcheck = db.Artists.Where(x => x.ArtistName == artistname ).FirstOrDefault();
            return artistcheck;
        }

        public List<Artist> artistlist()
        {
            List<Artist> artistlist = db.Artists.ToList();
            return artistlist;  
        }

        public List<Album> albumlist()
        {
            List<Album> albumlist = db.Albums.ToList();
            return albumlist;

        }

        public Artist findartist(int id)
        {
            Artist findartist = db.Artists.Where(x => x.ArtistID == id).FirstOrDefault();
            return findartist;
        }
    }
}