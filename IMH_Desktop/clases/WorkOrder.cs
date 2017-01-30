using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class WorkOrder
    {
        private String workOrderId;
        private int requiresTool;
        private String instructions;
        private Boolean validated;
        private DateTime date;

        public String WorkOrderId
        {
            get { return workOrderId; }
            set { workOrderId = value; }
        }
       

        public int RequiresTool
        {
            get { return requiresTool; }
            set { requiresTool = value; }
        }
       

        public String Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }
       

        public Boolean Validated
        {
            get { return validated; }
            set { validated = value; }
        }
       

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
