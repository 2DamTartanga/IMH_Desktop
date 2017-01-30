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
using System.Collections.Generic;

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
            Conexion.Close();
        }

        public Boolean comprobarDatos(string usu, string pass)
        {
            Boolean ok = false;
           
                conectar();
                Query.CommandText = "SELECT count(*) FROM users where username like '" + usu + "' AND password like '" + pass + "'";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();
                consultar.Read();

                if (consultar.GetInt32(0) == 1)
                {
                    ok = true;
                }

                Conexion.Close();
                return ok;
            }

        public void añadirUsuario(User usuario)
        {
            conectar();
            Query.CommandText = "INSERT into users VALUES ('"+usuario.Username+"','"+usuario.Password+"','"+usuario.TypeUser+"')";
            Query.Connection = Conexion;
            Query.ExecuteNonQuery();
            desconectar();
        }

        public void añadirOtros(User usuario)
        {
            conectar();
            Query.CommandText = "INSERT into others VALUES ('" + usuario.Username + "','" + usuario.Name + "','" + usuario.Surname + "','" + usuario.Email + "','" + usuario.Course + "')";
            Query.Connection = Conexion;
            Query.ExecuteNonQuery();
            desconectar();
        }

        public void borrarUser(User usuario)
        {
            conectar();
            Query.CommandText = "DELETE from users where username like '" + usuario.Username + "'";
            Query.Connection = Conexion;
            Query.ExecuteNonQuery();
            desconectar();
        }

        public void borrarOthers(User usuario)
        {
            conectar();
            Query.CommandText = "DELETE from others where username like '" + usuario.Username + "'";
            Query.Connection = Conexion;
            Query.ExecuteNonQuery();
            desconectar();
        }

        public List<User> getUsers()
        {
            List<User> listUser = new List<User>();
            User aux = new User();
            conectar();
            Query.CommandText = "SELECT * FROM users";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                aux = new User();
                aux.Username = consultar["username"].ToString();
                aux.Password = consultar["password"].ToString();
                listUser.Add(aux);
            }
            desconectar();
            return listUser;
        }

        public User getUser(String username)
        {
            User usuario = new User();
            conectar();
            Query.CommandText = "SELECT * FROM users where username like '" + username + "'";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                usuario.Username = consultar["username"].ToString();
                usuario.Password = consultar["password"].ToString();
				usuario.TypeUser = (char)consultar["type"];
            }
            desconectar();
            return usuario;
        }

        public User getOthers(String username)
        {
            User usuario = new User();
            conectar();
            Query.CommandText = "SELECT * FROM others where username like '"+username+"'";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                usuario.Username = consultar["username"].ToString();
                usuario.Name = consultar["name"].ToString();
                usuario.Surname = consultar["surname"].ToString();
                usuario.Email = consultar["email"].ToString();
                usuario.Course = consultar["course"].ToString();
            }
            desconectar();
            return usuario;
        }

        public void modificarUser(User usuario)
        {
            conectar();
            Query.CommandText = "UPDATE others set name='" + usuario.Name + "',surname='" + usuario.Surname + "',course='" + usuario.Course + "',email='" + usuario.Email + "' where username like '" + usuario.Username + "'";
            Query.Connection = Conexion;
            Query.ExecuteNonQuery();
            desconectar();
        }

        public User cojerUser(String userName)
        {
            User usuario=new User();
            conectar();
            Query.CommandText = "SELECT type FROM users where username like '" + userName + "'";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            if (consultar.Read())
            {
            	usuario.TypeUser = consultar.GetChar(0);
            }

            Conexion.Close();
            return usuario;
        }

    }
}
