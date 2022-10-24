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
    /// Логика взаимодействия для Win6.xaml
    /// </summary>
    public partial class Win6 : Window
    {
        public Win6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Win7().Show();  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t1.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
    }
}
