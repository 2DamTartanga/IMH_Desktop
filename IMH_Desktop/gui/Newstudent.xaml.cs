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
using IMH_Desktop.gui;

namespace IMH_Desktop.gui
{
    /// <summary>
    /// Lógica de interacción para Newstudent.xaml
    /// </summary>
    public partial class Newstudent : Window
    {
        DBManager dbManager = new DBManager();
        Adminmenu admin2 = new Adminmenu();

        public Newstudent(Adminmenu adminMenu)
        {
            InitializeComponent();
            textBoxNombreUser.Focus();
            admin2 = adminMenu;
        }

        private void buttonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            User usuario = new User();
            usuario.Username = textBoxNombreUser.Text;
            usuario.Password = passwordBox.Password;
            usuario.Name = textBoxName.Text;
            usuario.Surname = textBoxSurname.Text;
            usuario.Course = textBoxCourse.Text;
            usuario.Email = textBoxEmail.Text;
            
            if (radioButtonEspecial.IsChecked == true)
            {
                usuario.Type = 1; //especial
                usuario.TypeUser = "E";
            }
            if (radioButtonAdmin.IsChecked == true)
            {
                usuario.Type = 2; //admin
                usuario.TypeUser = "A";
            }
            if (radioButtonManten.IsChecked == true)
            {
                usuario.Type = 3; //mantenimiento
                usuario.TypeUser = "M";
            }
            if (radioButtonGeneral.IsChecked == true)
            {
                usuario.TypeUser = "G";
            }
            dbManager.añadirUsuario(usuario); // Añadir el usuario a la base de datos
            
            if (radioButtonOtros.IsChecked == true)
            {
                dbManager.añadirOtros(usuario); // Añadir los otros a la base de datos
            }
            MessageBox.Show("The user added correctly.");
            this.Close();
            admin2.vaciarListBox();
            admin2.llenarListBox();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxNombreUser.Clear();
            passwordBox.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxEmail.Clear();
            textBoxCourse.Clear();
            radioButtonEspecial.IsChecked = false;
            radioButtonAdmin.IsChecked = false;
            radioButtonManten.IsChecked = false;
            textBoxNombreUser.Focus();
        }

        

        private void radioButtonGeneral_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.IsEnabled = false;
            textBoxSurname.IsEnabled = false;
            textBoxEmail.IsEnabled = false;
            textBoxCourse.IsEnabled = false;
            radioButtonEspecial.IsEnabled = false;
            radioButtonAdmin.IsEnabled = false;
            radioButtonManten.IsEnabled = false;
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxEmail.Clear();
            textBoxCourse.Clear();
            radioButtonEspecial.IsChecked = false;
            radioButtonAdmin.IsChecked = false;
            radioButtonManten.IsChecked = false;
        }

        private void radioButtonOtros_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.IsEnabled = true;
            textBoxSurname.IsEnabled = true;
            textBoxEmail.IsEnabled = true;
            textBoxCourse.IsEnabled = true;
            radioButtonEspecial.IsEnabled = true;
            radioButtonAdmin.IsEnabled = true;
            radioButtonManten.IsEnabled = true;
        }


        
    }
}
