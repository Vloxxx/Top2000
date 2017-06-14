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
    /// Interaction logic for nieuwSong.xaml
    /// </summary>
    public partial class nieuwSong : Window
    {
        public nieuwSong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnAnnuleren control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            song s = new song();
            s.Show();
            this.Close();
        }
    }
}
