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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rekenapplicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wMin myWindow = new wMin();
            myWindow.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wDelen myWindow = new wDelen();
            myWindow.Show();
            this.Hide();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            wPlus myWindow = new wPlus();
            myWindow.Show();
            this.Hide();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnKeer_Click(object sender, RoutedEventArgs e)
        {
            wKeer myWindow = new wKeer();
            myWindow.Show();
            this.Hide();
        }
    }
}
