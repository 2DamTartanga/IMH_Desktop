using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    public class WorkOrder
    {
        private int idBreakdown;
        private int severity;
        private String others;
        private int typeMaintenance;
        private DateTime creationDate;

        public int IdBreakdown
        {
            get { return idBreakdown; }
            set { idBreakdown = value; }
        }

        public int Severity
        {
            get { return severity; }
            set { severity = value; }
        }

        public String Others
        {
            get { return others; }
            set { others = value; }
        }

        public int TypeMaintenance
        {
            get { return typeMaintenance; }
            set { typeMaintenance = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
    }
}
