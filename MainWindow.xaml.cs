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
        SqlDataReader reader;
        SqlCommand cmd;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Loaded event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fillcbJaar();

            StringBuilder sb = new StringBuilder();
            DataTable table = new DataTable();
            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            sb.Append("Database=TOP2000;");
            sb.Append("User Id=I5AO1;  Password=test;");

            string cs = sb.ToString();

            conn.ConnectionString = cs;


            try
            {
                conn.Open();
                fillDatatable();

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

        /// <summary>
        /// Handles the Closing event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            conn.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnArtiest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnArtiest_Click(object sender, RoutedEventArgs e)
        {
            Artiest a = new Artiest();
            a.Show();
            this.Close();
        }

        /// <summary>
        /// Fills the combobox jaar.
        /// </summary>
        public void fillcbJaar()
        {
            int eersteJaar = 1999;
            while (eersteJaar < DateTime.Now.Year - 1)
            {
                cbJaar.Items.Add(eersteJaar);
                eersteJaar = eersteJaar + 1;
            }
        }
        /// <summary>
        /// Fills the datatable dgData.
        /// </summary>
        public void fillDatatable()
        {
            cmd = new SqlCommand("SELECT top2000jaar, positie, titel, naam FROM lijst l join song s on s.songid=l.songid join artiest a on a.artiestid = s.artiestid where top2000jaar=" + cbJaar.SelectedItem.ToString() + "order by positie", conn);
            reader = cmd.ExecuteReader();
            table.Clear();
            table.Load(reader);
            dgData.ItemsSource = table.DefaultView;
        }

        /// <summary>
        /// Handles the DropDownClosed event of the cbJaar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbJaar_DropDownClosed(object sender, EventArgs e)
        {
            fillDatatable();
        }
    }
}
