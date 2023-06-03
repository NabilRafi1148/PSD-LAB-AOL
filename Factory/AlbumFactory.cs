using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AOL_Code_1.Model;

namespace AOL_Code_1.Factory
{
    public class AlbumFactory
    {
        public static Album createAlbum(string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            return new Album
            {
                
                AlbumName = AlbumName,
                AlbumImage = AlbumImage,
                AlbumPrice = AlbumPrice,
                AlbumStock = AlbumStock,
                AlbumDescription = AlbumDescription
            };
        }
    }
}