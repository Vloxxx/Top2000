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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Top2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable table = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            sb.Append("Database=TOP2000;");
            sb.Append("User Id=I5AO1;  Password=test;");

            DateTime nu = DateTime.Now;
            DateTime begin = new DateTime(1999, 1, 1);

            for(int i = begin.Year; i <= (nu.Year - 2); i++)
            {
                cbJaar.Items.Add(i);
            }

            //cbJaar.Items.Add("2015");

            string cs = sb.ToString();

            conn.ConnectionString = cs;


            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * from song s join lijst l on s.songid=l.songid join artiest a on a.artiestid=s.artiestid where Top2000Jaar=" + cbJaar.SelectedItem.ToString(), conn);
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            conn.Close();
        }

        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            artiestOverzicht a = new artiestOverzicht();
            a.ShowDialog();
        }
    }
}
