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
    /// Логика взаимодействия для Page20.xaml
    /// </summary>
    public partial class Page20 : Page
    {
        public Page20()
        {
            InitializeComponent();
        }

        private void BtnClickAns_Click(object sender, RoutedEventArgs e)
        {
            double x = 1.4;
            double p = 1.6;

            Task20 task20 = new Task20(x, p);
            Tb20.Text = task20.Result();
        }

        private void BtnClickMenu_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new MainPage());
        }
    }
}
