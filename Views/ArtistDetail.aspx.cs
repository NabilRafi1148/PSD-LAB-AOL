using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AOL_Code_1.Model;
using AOL_Code_1.Repository;

namespace AOL_Code_1.Views
{
    
    public partial class InsertArtist : System.Web.UI.Page
    {
        //Database1Entities db = new Database1Entities();
        ArtistRepository artistrepo = new ArtistRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Artist> artistlist = artistrepo.artistlist();
            List<Album> albumlist = artistrepo.albumlist();

            //int id = Convert.ToInt32(Request.QueryString["ArtistID"]);
            // id dummy
            int id = 1;
            Artist findartist = artistrepo.findartist(id);
            List<Artist> artistmatchingid = artistlist.Where(artist => albumlist.Any(album => album.ArtistID == artist.ArtistID) && artist.ArtistID == id).ToList();
            List<Album> albummatchingid = albumlist.Where(album => artistlist.Any(artist => artist.ArtistID == album.ArtistID) && album.ArtistID == id).ToList();

            ArtistImage.ImageUrl = "../Assets/Artist/" + findartist.ArtistImage;
            ArtistName.Text = findartist.ArtistName;

            var combinedDataList = artistmatchingid.Join(
                albummatchingid,
                artist => artist.ArtistID,
                album => album.ArtistID,
                (artist, album) => new
                {
                    
                    
                    AlbumImage = album.AlbumImage,
                    AlbumName = album.AlbumName,
                    AlbumPrice = album.AlbumPrice,
                    AlbumDescription = album.AlbumDescription,
                    AlbumID = album.AlbumID
                }).ToList();


            ArtistRepeater.DataSource = combinedDataList;
            ArtistRepeater.DataBind();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ini testing doang yeee
            Button clickedButton = (Button)sender;
            int albumID = Convert.ToInt32(clickedButton.CommandArgument);
            //Response.Redirect("~/Views/ArtistDetail.aspx");
            Response.Redirect("~/Views/AlbumDetail.aspx?id=" + albumID);
            // ini akan diarahin ke album detail (harusnya "~/Views/AlbumDetail.aspx")
        }
    }
}