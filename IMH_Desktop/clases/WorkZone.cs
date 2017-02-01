using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    public class WorkZone
    {
        private String workZoneID;
        private String name;

        public WorkZone(String workZoneID, String name)
        {
            this.workZoneID = workZoneID;
            this.name = name;
        }

        public String WorkZoneID
        {
            get { return workZoneID; }
            set { workZoneID = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
