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
    /// Lógica de interacción para Adminmenu.xaml
    /// </summary>
   
    public partial class Adminmenu : Window
    {
        DBManager dbManager = new DBManager();
        List<User> listUser = new List<User>();
        String id;

        public Adminmenu()
        {
            InitializeComponent();
            //PESTAÑA 1
            llenarListBox();
            vaciarRichTextBox();
        }

        //PESTAÑA 1
        public void llenarListBox(){
            
            listUser = dbManager.getUsers();   //Coger todos los usuarios
            for (int i = 0; i < listUser.Count; i++)
            {
                listBoxStudents.Items.Add(listUser[i].Username);
            }
        }

        public void vaciarListBox()
        {
            listBoxStudents.Items.Clear();
        }

        private void vaciarRichTextBox()
        {
            richTextBoxStuData.Document.Blocks.Clear();
        }


        private void buttonNewStu_Click(object sender, RoutedEventArgs e)
        {
            listBoxStudents.UnselectAll();
            vaciarRichTextBox();
            Newstudent student = new Newstudent(this);
            student.Show();
        }

        private void buttonModifyStu_Click(object sender, RoutedEventArgs e)
        {
            User usuario = new User();
            User usuario2 = new User();
            usuario = listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)];
            usuario2 = dbManager.getUser(usuario.Username);
            usuario = dbManager.getOthers(usuario.Username);
            usuario.TypeUser = usuario2.TypeUser;
            if (usuario.TypeUser == "G")
            {
                MessageBox.Show("The user is General User");
            }
            else
            {
                Modifystudent student = new Modifystudent(usuario);
                student.Show();
            }
        }

        private void buttonDeleteStu_Click(object sender, RoutedEventArgs e)
        {
            User usuario = new User();
            usuario = listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)];
            var result = MessageBox.Show("Do you want to delete the user?", "Delete user", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                dbManager.borrarUser(usuario);   //Borrar el usuario de la base de datos
                if (usuario.TypeUser != "G")
                {
                    dbManager.borrarOthers(usuario);   //Borrar el usuario de la base de datos
                }
                vaciarListBox();
                llenarListBox();
                vaciarRichTextBox();
            }
        }

        private void listBoxStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User usuario = new User();
            User usuario2 = new User();
            try
            {
                usuario = listUser[Convert.ToInt16(listBoxStudents.SelectedIndex)];
                usuario2 = dbManager.getUser(usuario.Username);
                usuario = dbManager.getOthers(usuario.Username);
                usuario.TypeUser = usuario2.TypeUser;
                vaciarRichTextBox();
                if (usuario.TypeUser == "G")
                {
                    richTextBoxStuData.AppendText("Username: " + usuario2.Username);
                    richTextBoxStuData.AppendText("\rType: General");
                }
                else
                {
                    richTextBoxStuData.AppendText("Username: " + usuario2.Username);
                    richTextBoxStuData.AppendText("\rName: " + usuario.Name);
                    richTextBoxStuData.AppendText("\rSurnames: " + usuario.Surname);
                    richTextBoxStuData.AppendText("\rCourse: " + usuario.Course);
                    richTextBoxStuData.AppendText("\rEmail: " + usuario.Email);
                    if (usuario.TypeUser == "E")
                        richTextBoxStuData.AppendText("\rType: Special");
                    else if (usuario.TypeUser == "A")
                        richTextBoxStuData.AppendText("\rType: Admin");
                    else
                        richTextBoxStuData.AppendText("\rType: Maintenance");
                }
            }
            catch { }
            
        }


        //PESTAÑA 4
        private void newmachine_Click(object sender, RoutedEventArgs e)
        {
            Newmachine2 nm2 = new Newmachine2();
            nm2.Show();
        }

        private void sharpener_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbsharpener.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void bandsaws_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbbandsaws.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void drillingmachines_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbdrillingmachines.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void benchgrinders_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbbenchgrinders.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.code = id;
            dmm.Show();
        }

        private void conventionallathes_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbconventionallathes.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void conventionalmillingmachines_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbconventionalmillingmachines.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void production_doubleclick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToString(lbproduction.SelectedItem);
            id = id.Substring(37);
            Delmodmachine dmm = new Delmodmachine(id);
            dmm.Show();
        }

        private void CargarMachines()
        {

        }

        

        



    }
}
