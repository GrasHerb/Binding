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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Win2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        public Win2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl.DataContext = new List<object> {null};
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbl.DataContext = new List<object> { "Не пусто" };
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lbl.DataContext = 1245;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lbl.DataContext = new List<object> { DependencyProperty.UnsetValue };
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            new Win3().Show();
        }
    }
}
