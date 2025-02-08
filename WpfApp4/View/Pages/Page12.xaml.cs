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
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();
        }

        private void BtnClickAns_Click(object sender, RoutedEventArgs e)
        {
            double q = 2;
            double b = 1.8;

            Task12 task12 = new Task12(q, b);
            Tb12.Text = task12.Result();
        }

        private void BtnClickMenu_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new MainPage());
        }
    }
}
