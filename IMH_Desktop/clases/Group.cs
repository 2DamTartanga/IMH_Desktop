using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class Group
    {
        private String name;
        private Boolean directive;


        public Boolean Directive
        {
            get { return directive; }
            set { directive = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
