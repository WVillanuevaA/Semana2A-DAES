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

namespace Semana2A
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static string usuario = "Eduardo";
        static string contraseña = "123456";

        public Login()
        {
            InitializeComponent();
        }

        private void button_ingresar_Click(object sender, RoutedEventArgs e)
        {
            if (
                textbox_usuario.Text.Equals(usuario) && 
                textbox_contraseña.Text.Equals(contraseña)
                )
            {
                MessageBox.Show("Inicio de Sesión Correctamente :D ");
            }
            else
            {
                MessageBox.Show("Inicio de Sesión Fallida :( ");
            }
            Menu menu = new Menu();
            menu.Show();

        }

        private void textbox_usuario_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            textbox_usuario.Text = "";
        }

        private void textbox_contraseña_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            textbox_contraseña.Text = "";
        }
    }

}

