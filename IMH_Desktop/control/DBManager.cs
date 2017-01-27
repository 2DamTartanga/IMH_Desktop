/*
 * Creado por SharpDevelop.
 * Usuario: Thoor
 * Fecha: 25/01/2017
 * Hora: 10:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;

namespace IMH_Desktop.control 
{
	/// <summary>
	/// Description of DBManager.
	/// </summary>
    

	public class DBManager : Interface1
	{
        MySqlCommand Query = new MySqlCommand();
        MySqlConnection Conexion = new MySqlConnection();
        MySqlDataReader consultar;
        public string connData = "Server=localhost;Database=bdaimh;Uid=user;Pwd=user;";
		
        public DBManager()
		{
            
		}

        public void conectar()
        {
            Conexion.ConnectionString = connData;
            Conexion.Open();   
        }

        public void desconectar()
        {
            
        }

        public Boolean comprobarDatos(string usu, string pass)
        {
            Boolean ok = false;
           
                conectar();
                Query.CommandText = "SELECT count(*) FROM users where username like '" + usu + "' AND password like '" + pass + "'";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                if (consultar.GetInt32(0) == 1)
                {
                    ok = true;
                }

                Conexion.Close();
                return ok;
            }
           
            
            
	
        

    }
}
