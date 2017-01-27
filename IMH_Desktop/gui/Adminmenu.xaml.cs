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
    /// Lógica de interacción para Adminmenu.xaml
    /// </summary>
    public partial class Adminmenu : Window
    {

        List<User> listUser = new List<User>();

        public Adminmenu()
        {
            InitializeComponent();
            //PESTAÑA 1
            llenarListBox();
            vaciarRichTextBox();
        }

        //PESTAÑA 1
        private void llenarListBox(){
            
            //listUser = dbmanager.getEstudMante();   Coger todos los estudiantes de mantenimiento
            for (int i = 0; i < listUser.Count; i++)
            {
                listBoxStudents.Items.Add(listUser[i].Name + " " + listUser[i].Surname);
            }
        }

        private void vaciarRichTextBox()
        {
            richTextBoxStuData.Document.Blocks.Clear();
        }

        private void listBoxStudents_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            richTextBoxStuData.AppendText("Nombre: " + listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)].Name);
            richTextBoxStuData.AppendText("\rApellido: " + listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)].Surname);
            richTextBoxStuData.AppendText("\rCurso: " + listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)].Surname);
            richTextBoxStuData.AppendText("\rEmail: " + listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)].Surname);
            richTextBoxStuData.AppendText("\rNombre de usuario: " + listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)].Username);
        }

        private void buttonNewStu_Click(object sender, RoutedEventArgs e)
        {
            Newstudent student = new Newstudent();
            student.Show();
        }

        private void buttonModifyStu_Click(object sender, RoutedEventArgs e)
        {
            //Modifystudent student = new Modifystudent();
            //student.Show();
        }

        private void buttonDeleteStu_Click(object sender, RoutedEventArgs e)
        {
            User usuario = new User();
            //usuario = listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)];
            var result = MessageBox.Show("Do you want to delete the student?", "Delete student", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                //dbManager.borrarEstud(usuario);   Borrar el usuario de la base de datos
            }
            

        }

        



    }
}
