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
    /// Логика взаимодействия для Page28.xaml
    /// </summary>
    public partial class Page28 : Page
    {
        public Page28()
        {
            InitializeComponent();
        }

        private void BtnClickAns_Click(object sender, RoutedEventArgs e)
        {
            double k = 1.7;
            double b = 2.19;

            Task28 task28 = new Task28(k, b);
            Tb28.Text = task28.Result();
        }

        private void BtnClickMenu_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.Myconnect.Navigate(new MainPage());
        }
    }
}
