using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop.control
{
    interface Interface1
    {
        void conectar();
        void desconectar();
        Boolean comprobarDatos(String usu,String pass);
    }
}
