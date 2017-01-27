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

namespace IMH_Desktop.gui
{
    /// <summary>
    /// Lógica de interacción para Newstudent.xaml
    /// </summary>
    public partial class Newstudent : Window
    {
        public Newstudent()
        {
            InitializeComponent();
            textBoxNombreUser.Focus();
        }

        private void buttonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            User usuario = new User();
            usuario.Name = textBoxName.Text;
            usuario.Surname = textBoxSurname.Text;
            //meter email y curso ...
            usuario.Super = false;
            //dbManager.añadirEstud(usuario);   Añadir el usuario a la base de datos
            MessageBox.Show("The student added correctly.");
            this.Close();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxNombreUser.Clear();
            passwordBox.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxEmail.Clear();
            textBoxCourse.Clear();
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
