using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Top2000
{
    /// <summary>
    /// Interaction logic for songOverzicht.xaml
    /// </summary>
    public partial class songOverzicht : Window
    {
        DataTable table = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;

        public songOverzicht()
        {
            InitializeComponent();
        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            sb.Append("Database=TOP2000;");
            sb.Append("User Id=I5AO1;  Password=test;");

            string cs = sb.ToString();
            conn.ConnectionString = cs;


            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT s.titel, a.naam, s.jaar FROM Song s JOIN Artiest a ON s.artiestid = a.artiestid WHERE s.titel LIKE '%" + tbZoek.Text + "%'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgData.ItemsSource = table.AsDataView();
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

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
