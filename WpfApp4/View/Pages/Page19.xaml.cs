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
    /// Логика взаимодействия для Page19.xaml
    /// </summary>
    public partial class Page19 : Page
    {
        public Page19()
        {
            InitializeComponent();
        }

        private void BtnClickAns_Click(object sender, RoutedEventArgs e)
        {
            double a = 4;
            double x = 3.7;

            Task19 task19 = new Task19(x, a);
            Tb19.Text = task19.Result();
        }

        private void BtnClickMenu_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new MainPage());
        }
    }
}
