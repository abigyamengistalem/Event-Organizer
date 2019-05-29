using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static Event_Organizer.ViewImages;

namespace Event_Organizer
{
    class DatabaseG
    {
        public static MySqlConnection conn;
        public static DataTable dataTable;
        public static void connection()
        {
            
            string connection = "Server=localhost;UserId=root;Database=Pagent;";
            dataTable = new DataTable();
            conn = new MySqlConnection(connection);
        }
        public static DataTable getGallery()
        {
            connection();
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter("SELECT * FROM gallery", conn);
            
            mySqlAdapter.Fill(dataTable);
            
            return dataTable;
             
        }
    }
}
