using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using AOL_Code_1.Model;
using AOL_Code_1.Repository;

namespace AOL_Code_1.Controller
{
    public class ArtistController
    {
        ArtistRepository artistrepo = new ArtistRepository();
        Database1Entities db = new Database1Entities();

        //INSERT_DETAIL VALIDATION

        public string CheckArtistName(string artistname)
        {
            string response = "";
            if (artistname.Equals("")) response = "Artist's name cannot be empty!";
            else if (artistrepo.GetArtist(artistname) != null) response = "Artist's name must be unique!";

            return response;

        }

        public string CheckArtistImage(FileUpload fileupload)
        {
            string response = "";
            if(fileupload.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(fileupload.FileName).ToLower();
             
                if (fileExtension.Contains(".jpg") == true || fileExtension.Contains(".jpeg") == true || fileExtension.Contains(".png") == true || fileExtension.Contains(".jfif") == true)
                {

                    response = "";
                }
                else if (fileExtension.Contains(".pdf") == true)
                {
                    response = "Image must be in png, jpg, jpeg, or jfif format";

                }
                else
                {
                    response = "Image must be in png, jpg, jpeg, or jfif format";

                }


                if (fileupload.FileContent.Length > 2 * 1024 * 1024)
                {
                    response = "File size must be lower than 2MB";

                }
            }
            else
            {
                response = "Artist image must be chosen!";
            }

            return response;
        }

        
        public string GetArtistName(int id)
        {
            Artist artist = db.Artists.Where(x => x.ArtistID == id).FirstOrDefault();
            string artistname = artist.ArtistName;

            return artistname;
        }

        public string GetArtistImage(int id)
        {
            Artist artist = db.Artists.Where(x => x.ArtistID == id).FirstOrDefault();
            //ArtistImg.ImageUrl = "../Assets/Artist/" + artist.ArtistImage; 
            string artistimage = "../Assets/Artist/" + artist.ArtistImage;
            return artistimage;
        }






    }
}