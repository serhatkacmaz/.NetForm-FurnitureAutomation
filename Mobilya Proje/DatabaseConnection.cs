using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilya_Proje
{
    class DatabaseConnection
    {
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection connection;


        public DatabaseConnection()
        {
            //Kaynak https://www.youtube.com/watch?v=me1FB6OpCeI 
            //sql veritabanı baglantısı 
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "root";
            build.Database = "mobilya";
            connection = new MySqlConnection(build.ToString());
        }

        //veritabanı bağlantısı aç
        public void OpenConnection()
        {
            connection.Open();
        }

        //veritabanı bağlantısı kapat
        public void CloseConnection()
        {
            connection.Close();
        }

        //veritabanı bağlantısını kontrol et, açık mı değil mi?
        public bool State()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //sql de ekleme silme güncelleme işlemlerini yap
        public void SqlProcess(string query)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //Filtreleme ve sorgulama işlemi
        public void filtering(string sql, DataGridView grid)
        {
            //kaynak https://www.youtube.com/watch?v=6jEDpBV6Inw&t=1678s
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];
            connection.Close();
        }

        //İlgili sorguya göre gelen verileri sırasıyla okuma
        public MySqlDataReader DataReader(string query)
        {
            // kaynak https://www.c-sharpcorner.com/UploadFile/f26fb0/connection-class-in-C-Sharp/
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
