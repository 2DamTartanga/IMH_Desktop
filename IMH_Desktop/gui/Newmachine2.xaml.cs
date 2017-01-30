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
using IMH_Desktop.clases;

namespace IMH_Desktop.gui
{
    /// <summary>
    /// Lógica de interacción para Newmachine2.xaml
    /// </summary>
    public partial class Newmachine2 : Window
    {
        DBManager dbManager = new DBManager();
        List<WorkZone> wz = new List<WorkZone>();
        List<Types> tp = new List<Types>();

        public Newmachine2()
        {
            InitializeComponent();
            Rellenar();
        }

        public void Rellenar()
        {
            //wz = dbManager.Obtenersection();
            for (int i = 0; i < wz.Count; i++)
            {
                cbsectionid.Items.Add(wz[i].Name);
            }
            //dbManager.Obtenertype();
            for (int i = 0; i < tp.Count; i++)
            {
                cbtypeid.Items.Add(tp[i].Nametype);
            }
        }

        private void addMachine_Click(object sender, RoutedEventArgs e)
        {
            Machine machine = new Machine();
            machine.Code = tbmachinecode.Text;
            machine.SerialNumber = tbserialnumber.Text;
            machine.Severity = tbseverity.Text;
            for (int i = 0; i < wz.Count; i++)
            {
                if (wz[i].Name.Equals(cbsectionid.SelectionBoxItem))
                {
                    machine.WorkzoneId = wz[i].WorkZoneID;
                }
            }
            for (int i = 0; i < tp.Count; i++)
            {
                if (tp[i].Nametype.Equals(cbtypeid.SelectionBoxItem))
                {
                    machine.Type = tp[i].Idtype;
                }
            }
            //dbManager.Newmachine(machine);
        }
    }
}
