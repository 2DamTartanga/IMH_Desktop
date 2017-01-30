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
    /// Lógica de interacción para Modifystuent.xaml
    /// </summary>
    public partial class Modifystudent : Window
    {
        DBManager dbManager = new DBManager();
        User usuario;

        public Modifystudent(User user)
        {
            InitializeComponent();
            usuario = user;
            cargarDatos();
        }

        private void cargarDatos()
        {
            textBoxName.Text = usuario.Name;
            textBoxSurname.Text = usuario.Surname;
            textBoxEmail.Text = usuario.Email;
            textBoxCourse.Text = usuario.Course;
        }

        private void buttonModify_Click(object sender, RoutedEventArgs e)
        {
            
                User usuario2 = new User();
                usuario2.Username = usuario.Username;
                usuario2.Name = textBoxName.Text;
                usuario2.Surname = textBoxSurname.Text;
                usuario2.Email = textBoxEmail.Text;
                usuario2.Course = textBoxCourse.Text;
                dbManager.modificarUser(usuario2);
                MessageBox.Show("The user modified correctly.");
                this.Close();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            cargarDatos(); 
        }
    }
}
