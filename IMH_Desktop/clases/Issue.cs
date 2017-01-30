using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class Issue
    {
        private String failureType;
        private DateTime date;
        private String subject;
        private String description;
        private String severity;

        public String FailureType
        {
            get { return failureType; }
            set { failureType = value; }
        }
    

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
       

        public String Subject
        {
            get { return subject; }
            set { subject = value; }
        }
      

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    

        public String Severity
        {
            get { return severity; }
            set { severity = value; }
        }


    }
}
