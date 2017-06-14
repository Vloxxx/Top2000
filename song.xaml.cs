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
    /// Interaction logic for song.xaml
    /// </summary>
    public partial class song : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="song"/> class.
        /// </summary>
        public song()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Handles the Click event of the btnTerug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnNewSong control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnNewSong_Click(object sender, RoutedEventArgs e)
        {
            nieuwSong ns = new nieuwSong();
            ns.Show();
            this.Close();
        }
    }
}
