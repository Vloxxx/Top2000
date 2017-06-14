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
            //hier roep ik de methode fillcbJaar aan om de combobax te vullen.
            fillcbJaar();
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
            try
            {
                // de start waarde is 1999 van het eerste jaar van de top 2000.
                int jaar = 1999;
                //zolang jaar kleiner dat de systeem jaar -1.
                while (jaar < DateTime.Now.Year - 1)
                {
                    //hier vul ik de combobox met de waarde van jaar.
                    cbJaar.Items.Add(jaar);
                    //hier tel ik er een jaar bij op.
                    jaar = jaar + 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Fills the datatable dgData.
        /// </summary>
        public void fillDatatable()
        {
            //ik maak eerst me tabel  schoon.
            table.Clear();
            //hier roep ik de stored prosedure aan.
            cmd = new SqlCommand("dbo.getTop2000FromYear", conn);
            //hier geef ik aan dat de sqlcommand een stored procedure is.
            cmd.CommandType = CommandType.StoredProcedure;
            //hier geef ik een parameter mee met de waarde van de combobox jaar.
            cmd.Parameters.Add(new SqlParameter("@Year", cbJaar.SelectedItem.ToString()));
            //hier voor ik de sql command uit en geef de waardes mee aan reader.
            reader = cmd.ExecuteReader();
            //hier maak ik een tabel aan met de waardes uit de database.
            table.Load(reader);
            //hier vul ik de datagrid.
            dgData.ItemsSource = table.DefaultView;
        }

        /// <summary>
        /// Handles the DropDownClosed event of the cbJaar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbJaar_DropDownClosed(object sender, EventArgs e)
        {
            //hier roep ik de fillDatatable methode aan.
            fillDatatable();
        }
    }
}
