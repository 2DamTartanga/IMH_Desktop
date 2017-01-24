using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class User
    {
        private String username;
        private String password;
        private String name;
        private String surname;
        private Boolean super;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Boolean Super
        {
            get { return super; }
            set { super = value; }
        }
    }
}
