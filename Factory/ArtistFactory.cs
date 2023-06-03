using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;


namespace AOL_Code_1.Factory
{
    public class ArtistFactory
    {
        public static Artist createArtist(string ArtistName, string ArtistImage)
        {
            return new Artist
            {
                ArtistName = ArtistName,
                ArtistImage = ArtistImage
            };
        }
    }
}