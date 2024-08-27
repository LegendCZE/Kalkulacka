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

namespace Kalkulck_projekt
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vyska_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(VyskaEntry.Text) && !String.IsNullOrEmpty(VahaEntry.Text))
            {
                bool vyskaT = double.TryParse(VyskaEntry.Text, out double vyska);
                bool vahaT = double.TryParse(VahaEntry.Text, out double vaha);


                if (vyskaT == true && vahaT == true)
                {
                    double bmi = (vaha) / Math.Pow(vyska / 100, 2);

                    BMI.Text = bmi.ToString();

                    if (bmi <= 18.5)
                    {
                        BMICategory.Text = "Podváha";
                    }
                    else if (bmi > 18.5 && bmi <= 24.9)
                    {
                        BMICategory.Text = "Normální váha";
                    }
                    else if (bmi >= 30)
                    {
                        BMICategory.Text = "Obezita";
                    }
                }
                else
                {
                    MessageBox.Show("Špatné hodnoty");
                }
            }
        }
    }
}
