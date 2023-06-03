using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;
using AOL_Code_1.Factory;
using AOL_Code_1.Repository;

namespace AOL_Code_1.Handler
{
    public class ArtistHandler
    {
        Database1Entities db = new Database1Entities();
        ArtistRepository artisrepo = new ArtistRepository();

        public void InsertArtist(string artistname, string artistimage)
        {

            artisrepo.addArtist(artistname, artistimage);
        }

        public void UpdateArtist(int id, string artistname, string artistimage)
        {

            artisrepo.updateArtist(id, artistname, artistimage);
        }

    }
}