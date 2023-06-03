using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;
using AOL_Code_1.Factory;

namespace AOL_Code_1.Repository
{
    //name,image,price,stock,description
    public class AlbumRepository
    {
        Database1Entities db = new Database1Entities();

        public void addAlbum(string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            db.Albums.Add(AlbumFactory.createAlbum(AlbumName, AlbumImage, AlbumPrice, AlbumStock, AlbumDescription));
            db.SaveChanges();   
        }

        public void deleteAlbum(int AlbumID)
        {
            Album album = db.Albums.Where(x => x.AlbumID == AlbumID).FirstOrDefault();
            db.SaveChanges();
        }

        public void updateAlbum(int AlbumID, string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            Album album = db.Albums.Where(x => x.AlbumID == AlbumID).FirstOrDefault();

            album.AlbumName = AlbumName;
            album.AlbumImage = AlbumImage;
            album.AlbumPrice = AlbumPrice;
            album.AlbumStock = AlbumStock;
            album.AlbumDescription = AlbumDescription;

            db.SaveChanges();
        }
    }
}