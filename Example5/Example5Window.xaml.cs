using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBindingExample
{
    /// <summary>
    /// Логика взаимодействия для Example5Window.xaml
    /// </summary>
    public partial class Example5Window : Window
    {
        public Example5Window()
        {
            InitializeComponent();
            DataContext = new CarViewModel();
        }
	
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ((CarViewModel)DataContext).AddCar();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((CarViewModel)DataContext).DeleteCar();
        }
    }
}
