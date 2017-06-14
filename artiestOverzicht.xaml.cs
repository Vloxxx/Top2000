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
    /// Interaction logic for artiestOverzicht.xaml
    /// </summary>
    public partial class artiestOverzicht : Window
    {
        DataTable table = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlDataReader reader;
        SqlCommand cmd;

        public artiestOverzicht()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnNieuwArtiest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnNieuwArtiest_Click(object sender, RoutedEventArgs e)
        {
            NieuwArtiest na = new NieuwArtiest();
            na.Show();
            this.Close();
        }


        /// <summary>
        /// Handles the Loaded event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //hier maak ik een string builder voor de connectionstring.
            StringBuilder sb = new StringBuilder();
            //hier geef ik de server aan.
            sb.Append(@"Server=(localdb)\mssqllocaldb;");
            //hier geef ik de database aan.
            sb.Append("Database=TOP2000;");
            //hier geef ik de usernamen en wachtwoord mee.
            sb.Append("User Id=I5AO1;  Password=test;");
            //hier converteer ik de stringbuilder naar een gewoone string.
            string cs = sb.ToString();
            //hier geef ik aan dat de connectionstring van conn cs is.
            conn.ConnectionString = cs;


            try
            {
                //hier maak ik een connectie met de database.
                conn.Open();
                //hier roep ik de methode aan die de datagrid vult.
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
        /// Fills the datatable.
        /// </summary>
        public void fillDatatable()
        {
            //ik maak eerst me tabel  schoon.
            table.Clear();
            //hier roep ik de stored prosedure aan.
            cmd = new SqlCommand("SELECT foto, naam FROM Artiest", conn);
            //hier voor ik de sql command uit en geef de waardes mee aan reader.
            reader = cmd.ExecuteReader();
            //hier maak ik een tabel aan met de waardes uit de database.
            table.Load(reader);
            //hier vul ik de datagrid.
            dgData.ItemsSource = table.DefaultView;
        }

        /// <summary>
        /// Handles the Click event of the btnTop2000 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnTop2000_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Closing event of the Window control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
