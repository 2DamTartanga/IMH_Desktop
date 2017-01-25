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
            textBoxName.Focus();
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
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxEmail.Clear();
            textBoxCourse.Clear();
            textBoxName.Focus();
        }
    }
}
