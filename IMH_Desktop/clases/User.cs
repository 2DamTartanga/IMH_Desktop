using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    public class User
    {
        private String username;
        private String password;
        private String name;
        private String surname;
        private String course;
        private String email;
        private int type;
        private String typeUser;


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

        public String Course
        {
            get { return course; }
            set { course = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public String TypeUser
        {
            get { return typeUser; }
            set { typeUser = value; }
        }
    }
}
