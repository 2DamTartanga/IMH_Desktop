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
    /// Lógica de interacción para Technicianmenu.xaml
    /// </summary>
    public partial class Technicianmenu : Window
    {
        User usu;
        DBManager dbManager = new DBManager();

        public Technicianmenu()
        {
            InitializeComponent();
            try
            {
                List<WorkOrder> worklist = dbManager.getWorkorderOfUser("ismael");
                foreach (WorkOrder workorder in worklist)
                {
                    listBox1.Items.Add("IDBreakdown: " + workorder.IdBreakdown + "  CreationDate: " + workorder.CreationDate.ToString("yyyy/MM/dd"));
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
