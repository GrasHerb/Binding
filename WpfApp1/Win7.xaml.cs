using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Win7.xaml
    /// </summary>
    public partial class Win7 : Window
    {
        private Random _random = new Random();
        public Win7()
        {
            InitializeComponent();
            DataContext = new Data();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Win8().Show();
        }
        private void ChangeItem1_Click(object sender, RoutedEventArgs e)
        {
            ((Data)DataContext).Item1 = _random.Next(10000);
        }

        private void ChangeItem2_Click(object sender, RoutedEventArgs e)
        {
            ((Data)DataContext).Item2 = _random.Next(10000);
        }
        public class Data : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            }

            private int _item1;
            public int Item1
            {
                get
                {
                    System.Threading.Thread.Sleep(1000);
                    return _item1;
                }
                set
                {
                    if (_item1 != value)
                    {
                        OnPropertyChanged();
                        _item1 = value;

                    }
                }
            }

            private int _item2;
            public int Item2
            {
                get
                {
                    System.Threading.Thread.Sleep(1000);
                    return _item2;
                }
                set
                {
                    if (_item2 != value)
                    {
                        OnPropertyChanged();
                        _item2 = value;

                    }
                }
            }
        }
    }
}
