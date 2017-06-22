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
                cmd = new SqlCommand("SELECT a.foto, a.naam  FROM Artiest a where a.naam LIKE '%" + tbZoek.Text + "%'", conn);
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


        /// <summary>
        /// Handles the DoubleClick event of the Row control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            DataRowView oDataRowView = dgData.SelectedItem as DataRowView;
            string sValue = "";

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["Naam"] as string;
            }
            Artiest a = new Artiest();
            a.Show();
            this.Close();
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
