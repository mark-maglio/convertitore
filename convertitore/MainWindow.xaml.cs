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

namespace convertitore
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
            string n = TxtNumero.Text;
            if(cmbBase.SelectedIndex== 0) //dabinario
            {
                int ris = Convert.ToInt32(n, 2);
                TxtRisultato.Text = ris.ToString();
            }
            else if (cmbBase.SelectedIndex == 1)//dadecimale
            {
                int a = int.Parse(n);
                string ris = "";
                do
                {
                    int r = a % 2;
                    ris = r + ris;
                    a = a / 2;
                } while (a > 0);
                TxtRisultato.Text = ris;
            }
        }
    }
}
