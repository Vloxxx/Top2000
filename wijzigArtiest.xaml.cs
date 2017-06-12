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
    /// Interaction logic for wijzigArtiest.xaml
    /// </summary>
    public partial class wijzigArtiest : Window
    {
        public wijzigArtiest()
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

        }

        /// <summary>
        /// Handles the Click event of the btnOpslaan control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Artiest a = new Artiest();
            a.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the Annuleren control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Annuleren_Click(object sender, RoutedEventArgs e)
        {
            Artiest a = new Artiest();
            a.Show();
            this.Close();
        }
    }
}
