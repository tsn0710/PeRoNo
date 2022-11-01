using SE1634_Windows.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumAddEditDelete.DAL
{
    internal class ArtistDAO:DAO
    {
        private static ArtistDAO instance;

        private ArtistDAO() : base() { }

        static ArtistDAO()
        {
            instance = new ArtistDAO();
        }

        public static ArtistDAO GetInstance() => instance;

        public DataTable GetDataTable() => base.GetDataTable("select Name from Artists");
    }
}
