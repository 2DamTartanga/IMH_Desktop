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
using IMH_Desktop.clases;
using IMH_Desktop.control;

namespace IMH_Desktop
{
    /// <summary>
    /// Lógica de interacción para Delmodmachine.xaml
    /// </summary>
    public partial class Delmodmachine : Window
    {

        DBManager dbManager = new DBManager();
        Machine machine = new Machine();
        List<WorkZone> wz = new List<WorkZone>();
        List<Types> tp = new List<Types>();
        public String code;

        public Delmodmachine(String id)
        {
            InitializeComponent();
            code = id;
            Rellenar();
        }

        public void Rellenar()
        {
            //machine = dbManager.ObtenerMaquina(code);
            tbmachinecode.Text = machine.Code;
            tbserialnumber.Text = machine.SerialNumber;
            tbseverity.Text = machine.Severity;
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

        private void modifymachine_click(object sender, RoutedEventArgs e)
        {
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
            //dbManager.Modifymachine(machine);

        }

        private void deletemachine_click(object sender, RoutedEventArgs e)
        {
            //dbManager.Deletemachine(tbmachinecode.Text.ToString());
        }
    }
}
