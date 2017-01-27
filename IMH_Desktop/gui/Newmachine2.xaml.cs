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
    /// Lógica de interacción para Newmachine2.xaml
    /// </summary>
    public partial class Newmachine2 : Window
    {
        public Newmachine2()
        {
            InitializeComponent();
        }

        private void addMachine_Click(object sender, RoutedEventArgs e)
        {
            Machine machine = new Machine();
            machine.Code = textBoxCode.Text;
            machine.SerialNumber = textBoxSerial.Text;
            machine.Severity = textBoxSeverity.Text;
            machine.WorkzoneId = comboBoxSection.SelectedItem.ToString()
            machine.Type = comboBoxType.SelectedItem.ToString();

        }
    }
}
