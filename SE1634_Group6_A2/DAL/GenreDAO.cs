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
    internal class GenreDAO:DAO
    {
        private static GenreDAO instance;

        private GenreDAO() : base() { }

        static GenreDAO()
        {
            instance = new GenreDAO();
        }

        public static GenreDAO GetInstance() => instance;

        public DataTable GetDataTable() => base.GetDataTable("select * from Genres");

    }
}
