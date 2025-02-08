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
using WpfApp4.Utility.Tasks;

namespace WpfApp4.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnClickAns_Click(object sender, RoutedEventArgs e)
        {
            double x = 1.3;

            Task2 task2 = new Task2(x);
            Tb2.Text = $"{task2.Result()}";
        }
        private void BtnClickMenu_Click_1(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new MainPage());
        }
    }
}
