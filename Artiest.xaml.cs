using System;
using System.Collections.Generic;
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
    /// Interaction logic for Artiest.xaml
    /// </summary>
    public partial class Artiest : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Artiest"/> class.
        /// </summary>
        public Artiest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnWijzig control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            wijzigArtiest wa = new wijzigArtiest();
            wa.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnVerwijder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Weet u zeker dat u deze artiest wil verwijderen");
        }

        /// <summary>
        /// Handles the Click event of the btnTerug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
