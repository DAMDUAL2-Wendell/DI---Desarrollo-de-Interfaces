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

namespace ejercicio1._3
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

        private void asdf(object sender, TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textboxTlf(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbTelefono.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se aceptan numeros.");
                txtbTelefono.Text = txtbTelefono.Text.Remove(txtbTelefono.Text.Length - 1);
            }
        }

        private void TextChangedCP(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbCP.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se aceptan numeros.");
                txtbCP.Text = txtbCP.Text.Remove(txtbCP.Text.Length - 1);
            }
        }


        private void btnClickAceptar(object sender, RoutedEventArgs e)
        {
            //Comprobar email valido
            if (txtbEmail.Text.Length > 0)
            {
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtbEmail.Text))
                {
                    MessageBox.Show("Email invalido.");
                    txtbEmail.Clear();
                }
            }

            //Comprobar DNI valido
            if (txtbNIF.Text.Length > 0)
            {
                System.Text.RegularExpressions.Regex reg2 = new System.Text.RegularExpressions.Regex(@"^([0-9])8");
                if (!reg2.IsMatch(txtbNIF.Text))
                {
                    MessageBox.Show("DNI invalido.");
                    txtbNIF.Clear();
                }
            }
                
        }

        private void TextChangedNumCuenta(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbCP.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se aceptan numeros.");
                txtbCP.Text = txtbCP.Text.Remove(txtbCP.Text.Length - 1);
            }
        }
    }
 
}
