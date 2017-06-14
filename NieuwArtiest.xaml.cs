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
    /// Interaction logic for NieuwArtiest.xaml
    /// </summary>
    public partial class NieuwArtiest : Window
    {
        public NieuwArtiest()
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
            MessageBox.Show("opslaan gelukt");
        }

        /// <summary>
        /// Handles the Click event of the btnAnnuleren control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            artiestOverzicht ao = new artiestOverzicht();
            ao.Show();
        }
    }
}
