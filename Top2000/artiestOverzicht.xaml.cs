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
    /// Interaction logic for artiestOverzicht.xaml
    /// </summary>
    public partial class artiestOverzicht : Window
    {
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
    }
}
