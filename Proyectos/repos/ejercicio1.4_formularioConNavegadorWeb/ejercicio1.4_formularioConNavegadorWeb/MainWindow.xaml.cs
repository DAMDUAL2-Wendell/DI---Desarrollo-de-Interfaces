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

namespace ejercicio1._4_formularioConNavegadorWeb
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

        private void ClickBtnAtras(object sender, RoutedEventArgs e)
        {
            webBrowser.GoBack();
        }

        private void ClickBtnAdelante(object sender, RoutedEventArgs e)
        {
            webBrowser.GoForward();
        }

        private void ClickBtnCargar(object sender, RoutedEventArgs e)
        {

            try
            {
                webBrowser.Navigate(url.Text);
            }catch(Exception)
            {
                
            }
            
        }

        private void ClickBtnRefrescar(object sender, RoutedEventArgs e)
        {
            webBrowser.Refresh();
        }
    }
}
