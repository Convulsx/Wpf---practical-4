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
using WpfApp4.Servers;

namespace WpfApp4.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page1());
        }
        private void BtnWork4_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page4());
        }

        private void BtnWork2_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page2());
        }

        private void BtnWork3_Click_1(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page3());
        }

        private void BtnWork5_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page5());
        }

        private void BtnWork6_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page6());
        }

        private void BtnWork7_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page7());
        }

        private void BtnWork8_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page8());
        }

        private void BtnWork9_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page9());
        }

        private void BtnWork10_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page10());
        }

        private void BtnWork11_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page11());
        }

        private void BtnWork12_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page12());
        }

        private void BtnWork13_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page13());
        }

        private void BtnWork14_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page14());
        }

        private void BtnWork15_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page15());
        }

        private void BtnWork16_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page16());
        }

        private void BtnWork17_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page17());
        }

        private void BtnWork18_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page18());
        }

        private void BtnWork19_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page19());
        }

        private void BtnWork20_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page20());
        }

        private void BtnWork21_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page21());
        }

        private void BtnWork22_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page21());
        }

        private void BtnWork23_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page22());
        }

        private void BtnWork24_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page23());
        }

        private void BtnWork25_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page24());
        }

        private void BtnWork26_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page25());
        }

        private void BtnWork27_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page26());
        }

        private void BtnWork28_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page27());
        }

        private void BtnWork29_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page28());
        }

        private void BtnWork30_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page29());
        }

        private void Page_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new Page30());
        }
    }
}
