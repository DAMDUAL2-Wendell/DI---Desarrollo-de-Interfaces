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

namespace Practica2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

         

         
        private void CheckedVerde(object sender, RoutedEventArgs e)
        {
             //rectangulo.Fill = new SolidColorBrush(Color.FromRgb(0, 111, 0));
            rectangulo.Fill = Brushes.Green;
        }

        private void CheckedAzul(object sender, RoutedEventArgs e)
        {
            //rectangulo.Fill = new SolidColorBrush(Color.FromRgb(176, 224, 230));
            rectangulo.Fill = Brushes.Blue;
        }

        private void CheckedRojo(object sender, RoutedEventArgs e)
        {
            //rectangulo.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            rectangulo.Fill = Brushes.Red;
        }

        private void CheckedAmarillo(object sender, RoutedEventArgs e)
        {
            //rectangulo.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            rectangulo.Fill = Brushes.Yellow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rectangulo.Fill = null;
            rdbAzul.IsChecked = false;
            rdbRojo.IsChecked = false;
            rdbVerde.IsChecked = false;
            rdbAmarillo.IsChecked = false;

        }
        

    }
}
