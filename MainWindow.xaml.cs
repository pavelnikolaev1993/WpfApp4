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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDouble = rateDollar * sumDollar;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resSumE.Text = resEuro.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateGri = Convert.ToDouble(rateGr.Text);
            double sumGri = Convert.ToDouble(sumGr.Text);
            double resGri = rateGri * sumGri;
            resSumGr.Text = resGri.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateArm = Convert.ToDouble(rateAr.Text);
            double sumArm = Convert.ToDouble(sumAr.Text);
            double resArm = rateArm * sumArm;
            resSumAr.Text = resArm.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateInc.Text);
           double resInch = rateInch / 39.37;
            resSumInc.Text = resInch.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateFt.Text);
            double resInch = rateInch / 3.2808;
            resSumFt.Text = resInch.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateMl.Text);
            double resInch = rateInch * 1609.34;
            resSumMl.Text = resInch.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateV.Text);
            double resInch = rateInch * 1066.8;
            resSumV.Text = resInch.ToString();
        }
    }
}
