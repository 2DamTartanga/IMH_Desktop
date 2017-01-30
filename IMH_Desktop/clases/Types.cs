using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop.clases
{
    class Types
    {
        private int idtype;
        private String nametype;

        public Types(int idtype, string nametype)
        {
            this.idtype = idtype;
            this.nametype = nametype;
        }

        public int Idtype
        {
            get { return idtype; }
            set { idtype = value; }
        }

        public String Nametype
        {
            get { return nametype; }
            set { nametype = value; }
        }

    }
}
