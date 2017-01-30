using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IMH_Desktop.control;

namespace IMH_Desktop.gui
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        DBManager dbmanager= new DBManager()
            ;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Boolean camposCorrectos= comprobarCampos();
            if (camposCorrectos) {
                MessageBox.Show("Campos correctos");
                Boolean control=dbmanager.comprobarDatos(txtBoxUser.Text,passwordBox.Password);
                if (control)
                {
                    User usu = dbmanager.cojerUser(txtBoxUser.Text);

                    MessageBox.Show(usu.TypeUser);
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private Boolean comprobarCampos()
        {
            //Inhabilitar boton Login hasta que no se rellenen todos los campos
            Boolean bien = false;
            if (txtBoxUser.Text.Trim() != "" && passwordBox.Password.Trim() != "")
            {
                if (radioBtnEus.IsChecked == true || radioBtnEng.IsChecked == true)
                {
                    bien = true;
                    
                }
                else
                {
                    MessageBox.Show("Hay que elegir un idioma");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios");
                txtBoxUser.Text = "";
                passwordBox.Password = "";
            }
            return bien;
        }

        private void comprobarUsuario() { 
            int tipoUsu=3;
            //tipoUsu=manager.tipoUsuario(txtBoxUser.Text,passwordBox.Password)
 
            switch (tipoUsu) { 
                case 1:
                    MessageBox.Show("Eres admin");
                    Adminmenu window = new Adminmenu();
                    window.Show();
                    break;
                case 2:
                    MessageBox.Show("Eres tecnico");
                    Technicianmenu windowT = new Technicianmenu();
                    windowT.Show();
                    break;
                case 3:
                    Startmenu windowS = new Startmenu();
                     windowS.Show();
                    break;
                default:
                    MessageBox.Show("No existe el usuario introducido");
                    break;
            
            }
        }

    }

  
}
