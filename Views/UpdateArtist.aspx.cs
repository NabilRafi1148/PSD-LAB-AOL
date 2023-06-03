using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AOL_Code_1.Model;
using AOL_Code_1.Repository;
using AOL_Code_1.Controller;
using AOL_Code_1.Handler;

namespace AOL_Code_1.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        ArtistRepository artistrepository = new ArtistRepository();
        ArtistController artistcontroller = new ArtistController();
        ArtistHandler artisthandler = new ArtistHandler();
        protected void Page_Load(object sender, EventArgs e)

        {

            //int id = Convert.ToInt32(Request.QueryString["ArtistID"]);
            int id = 1;
            //Artist artist = db.Artists.Where(x => x.ArtistID == id).FirstOrDefault();
            //ArtistName.Text = artist.ArtistName;
            //ArtistImg.ImageUrl = "../Assets/Artist/" + artist.ArtistImage; 

            //ArtistNameTxt.Text = artist.ArtistName;

            ArtistName.Text = artistcontroller.GetArtistName(id);
            ArtistImg.ImageUrl = artistcontroller.GetArtistImage(id);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(Request.QueryString["id"]);  (ID ASLi)

            int id = 1;  // ID Dummy\

            string ArtistName = ArtistNameTxt.Text;

            ArtistNameLbl.Text = artistcontroller.CheckArtistName(ArtistName);

            ArtistImageLbl.Text = artistcontroller.CheckArtistImage(FileUpload1);


            if (ArtistImageLbl.Text.Equals("") && ArtistNameLbl.Text.Equals(""))
            {
                //string ArtistName = ArtistNameTxt.Text;
                FileUpload1.SaveAs(Server.MapPath("~") + "/Assets/Artist/" + FileUpload1.FileName);
                string ArtistImage = FileUpload1.FileName;

                //artistrepository.updateArtist(id, ArtistName, ArtistImage);
                artisthandler.UpdateArtist(id, ArtistName, ArtistImage);


                //Response.Redirect("~/Views/ArtistDetail.aspx");
                Response.Redirect("~/Views/HomePage.aspx");
                // ini harusnya balik ke homepage
            }
        }
    }
}