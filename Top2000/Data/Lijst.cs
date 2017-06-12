using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace Data
{
    public class Lijst
    {
        private int top2000jaar;
        private int positie;

        public static List<Song> ListSong = new List<Song>();
        public static List<Artiest> ListArtiest = new List<Artiest>();

        public static void AddArtiest()
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd;
            StringBuilder sb = new StringBuilder();

            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            sb.Append("Database=TOP2000;");
            sb.Append("User Id=I5AO1;  Password=test;");

            string cs = sb.ToString();

            conn.ConnectionString = cs;

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Artiest", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                
                foreach (var v in table.Rows.Count.ToString())
                {
                    //ListArtiest.Add(new Artiest(table.Rows.));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }
    }
}