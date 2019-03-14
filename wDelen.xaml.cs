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
    /// Interaction logic for wDelen.xaml
    /// </summary>
    public partial class wDelen : Window
    {
        int iGetal1;
        int iGetal2;
        int iUitkomst;
        Random rnd = new Random();
        int aantalSommen = 1;
        int goed, fout;
        public wDelen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            {
                {
                    int i;
                    if (String.IsNullOrEmpty(txtAntwoord.Text))
                    {
                        MessageBox.Show("Je moet iets invullen!");
                        return;
                    }
                    else if (!int.TryParse(txtAntwoord.Text, out i))
                    {
                        MessageBox.Show("Je moet een getal invullen!");
                        return;
                    }
                    // Uitkomst uitrekenen (Getal 1 + Getal 2)
                    int iUitkomst = iGetal1 / iGetal2;
                    // Input uitlezen van de gebruiker
                    string sAntwoord = txtAntwoord.Text;
                    int iAntwoord = Convert.ToInt32(sAntwoord);
                    // Antwoord vergelijken met Uitkomst en feedback geven



                    if (iUitkomst == iAntwoord)
                    {
                        wJuist myWindow = new wJuist();
                        myWindow.Show();
                        goed++;
                    }
                    else
                    {
                        wFout myWindow = new wFout();
                        myWindow.Show();
                        fout++;
                    }

                    aantalSommen++;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                //Creeërt som
                {
                    if (aantalSommen < 6)
                    {
                        GenereerSom();
                    }
                    else
                    {
                        wResultaat myWindow = new wResultaat(goed, fout);
                        myWindow.Show();
                        this.Close();
                    }
                }
            }
        }
        public void GenereerSom()

        {
            iGetal1 = rnd.Next(1, 100);
            iGetal2 = rnd.Next(1, 100);
            Controle();
        }

        public void Controle()
        {
            iUitkomst = iGetal1 / iGetal2;
            if (iUitkomst <= 0 || iGetal1 % iGetal2 != 0)
            {
                GenereerSom();
            }
            else

            {
                if (aantalSommen < 6)
                {
                    lblGetal1.Content = null;
                    lblGetal2.Content = null;

                    lblGetal1.Content = iGetal1;
                    lblGetal2.Content = iGetal2;
                    lblAantalSommen.Content = " Som: " + aantalSommen;
                    txtAntwoord.Clear();
                }
                else
                {

                    wResultaat myWindow = new wResultaat(goed, fout);
                    myWindow.Show();
                    this.Close();
                }
            }
        }
    }
}
