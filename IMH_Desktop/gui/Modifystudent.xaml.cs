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
    /// Lógica de interacción para Modifystuent.xaml
    /// </summary>
    public partial class Modifystudent : Window
    {

        public Modifystudent()
        {
            InitializeComponent();
        }

        private void buttonModify_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Username = textBoxName.Text;
            user.Surname = textBoxName.Text;
            //user.Course = textBoxName.Text;
            //user.Email = textBoxName.Text;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxCourse.Text = "";
            textBoxEmail.Text = "";
        }
    }
}
