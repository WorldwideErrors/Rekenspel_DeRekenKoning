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

namespace Rekenapplicatie
{
    /// <summary>
    /// Interaction logic for wResultaat.xaml
    /// </summary>
    public partial class wResultaat : Window
    {
        
        public wResultaat(int goed, int fout)
        {
            InitializeComponent();
            lblGoed.Content = goed.ToString();
            lblFout.Content = fout.ToString();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
            this.Hide();

            }

             
        }
        
    }

