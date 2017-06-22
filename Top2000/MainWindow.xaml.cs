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
            this.cbJaar.SelectionChanged += new SelectionChangedEventHandler(OnMyComboBoxChanged);
        }

        /// <summary>
        /// Handles the Loaded event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
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

            string cs = sb.ToString();

            conn.ConnectionString = cs;


            try
            {
                conn.Open();
<<<<<<< HEAD

               // cmd = new SqlCommand("SELECT * from song", conn);
               // SqlDataReader reader = cmd.ExecuteReader();
               // DataTable table = new DataTable();
               // table.Load(reader);
               // dgData.ItemsSource = table.AsEnumerable();
=======
                cmd = new SqlCommand("SELECT l.positie, s.titel, a.naam, s.jaar from song s join lijst l on s.songid=l.songid join artiest a on a.artiestid=s.artiestid where Top2000Jaar=" + cbJaar.SelectedItem.ToString() + "ORDER BY l.positie ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgData.ItemsSource = table.AsDataView();
>>>>>>> origin/master
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            conn.Close();
        }

        /// <summary>
        /// Handles the Closing event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            conn.Close();
        }

<<<<<<< HEAD
        /// <summary>
        /// Handles the Click event of the btnArtiest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            Artiest a = new Artiest();
            a.Show();
=======
        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            artiestOverzicht a = new artiestOverzicht();
            a.ShowDialog();
        }

        private void btnSong_Click(object sender, RoutedEventArgs e)
        {
            songOverzicht s = new songOverzicht();
            s.ShowDialog();
        }
        private void OnMyComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (sender as ComboBox).SelectedItem as string;

            StringBuilder sb = new StringBuilder();
            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            sb.Append("Database=TOP2000;");
            sb.Append("User Id=I5AO1;  Password=test;");

            string cs = sb.ToString();

            conn.ConnectionString = cs;


            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT l.positie, s.titel, a.naam, s.jaar from song s join lijst l on s.songid=l.songid join artiest a on a.artiestid=s.artiestid where Top2000Jaar=" + cbJaar.SelectedItem.ToString() + "ORDER BY l.positie ASC", conn);
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
            conn.Close();
>>>>>>> origin/master
        }
    }
}
