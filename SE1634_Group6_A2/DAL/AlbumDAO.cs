using assignment2prn.Models;
using Microsoft.Data.SqlClient;
using SE1634_Windows.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumAddEditDelete.DAL
{
    internal class AlbumDAO:DAO
    {
        private static AlbumDAO instance;
        private AlbumDAO() : base() { }

        static AlbumDAO()
        {
            instance = new AlbumDAO();
        }

        public static AlbumDAO GetInstance() => instance;

        public DataTable GetDataTable() => base.GetDataTable("select AlbumId, ArtistId, Title, Price, AlbumUrl from Albums");

        public DataTable GetDataTableById(int AlbumId)
        {
            SqlCommand cmd = new SqlCommand("select * from Albums where AlbumId = @AlbumId");
            cmd.Parameters.AddWithValue("@AlbumId", AlbumId);
            return base.GetDataTable2(cmd);
        }
        public DataTable GetDataTableByGenreAndTitle(Album album)
        {
            if(album.GenreId == 0 && album.Title == "")
            {
                return base.GetDataTable("select AlbumId, ArtistId, Title, Price, AlbumUrl from Albums");
            }
            if (album.GenreId != 0 && album.Title.Equals(""))
            { 
                SqlCommand cmd = new SqlCommand("select AlbumId, ArtistId, Title, Price, AlbumUrl from Albums where genreId = @genreId");
                cmd.Parameters.AddWithValue("@genreId", album.GenreId);
                return base.GetDataTable2(cmd);
            }
            if (album.GenreId == 0 && !album.Title.Equals(""))
            {
                SqlCommand cmd = new SqlCommand("select AlbumId, ArtistId, Title, Price, AlbumUrl from Albums where Title like @title");
                album.Title = "%" + album.Title + "%";
                cmd.Parameters.AddWithValue("@title", album.Title);
                return base.GetDataTable2(cmd);
            }
            else
            {
               SqlCommand cmd = new SqlCommand("select AlbumId, ArtistId, Title, Price, AlbumUrl from Albums where GenreId = @GenreId and Title like @title");
               album.Title = "%" + album.Title + "%";
               cmd.Parameters.AddWithValue("@genreId", album.GenreId);
               cmd.Parameters.AddWithValue("@title", album.Title);              
               return base.GetDataTable2(cmd);      
            }       
        }
        
        public bool Insert(Album album)
        {
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Albums ON Insert into Albums(AlbumId, GenreId, ArtistId, Title, Price, AlbumUrl) Values(@AlbumId, @GenreId, @ArtistId, @Title, @Price, @AlbumUrl) SET IDENTITY_INSERT Albums OFF ");
            cmd.Parameters.AddWithValue("@AlbumId", album.AlbumId);
            cmd.Parameters.AddWithValue("@GenreId", album.GenreId);
            cmd.Parameters.AddWithValue("@ArtistId", album.ArtistId);
            cmd.Parameters.AddWithValue("@Title", album.Title);
            cmd.Parameters.AddWithValue("@Price", album.Price);
            cmd.Parameters.AddWithValue("@AlbumUrl", album.AlbumUrl);

            return base.Update(cmd);
        }

        public bool Edit(Album album)
        {
            SqlCommand cmd = new SqlCommand("Update Albums SET GenreId=@GenreId, ArtistId=@ArtistId, Title=@Title, Price=@Price, AlbumUrl=@AlbumUrl WHERE AlbumId = @AlbumId");
            cmd.Parameters.AddWithValue("@GenreId", album.GenreId);
            cmd.Parameters.AddWithValue("@ArtistId", album.ArtistId);
            cmd.Parameters.AddWithValue("@Title", album.Title);
            cmd.Parameters.AddWithValue("@Price", album.Price);
            cmd.Parameters.AddWithValue("@AlbumUrl", album.AlbumUrl);
            cmd.Parameters.AddWithValue("@AlbumId", album.AlbumId);

            return base.Update(cmd);
        }

        public bool Delete(int AlbumId)
        {

            SqlCommand cmd = new SqlCommand("DELETE Carts WHERE AlbumId = @AlbumId DELETE OrderDetails WHERE AlbumId = @AlbumId DELETE Albums WHERE AlbumId = @AlbumId");           
            cmd.Parameters.AddWithValue("@AlbumId", AlbumId);
            return base.Update(cmd);

        }
    }
}
