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
    /// Логика взаимодействия для Win8.xaml
    /// </summary>
    public partial class Win8 : Window
    {
        
        Random rnd = new Random();
        public Win8()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            DataContext = new data() { randomValue = rnd.Next(1000) };
        }
        class data
        {
            public int randomValue { get; set; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Win9().Show();
        }
    }
}
