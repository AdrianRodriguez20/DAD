using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ado
{
       public class UsuarioADO : Crud<Usuario, String>
        {

        private static DBConnection dataSource;

        public UsuarioADO()
        {
            dataSource = DBConnection.getInstance();
        }
        public bool delete(string id)
        {
            bool exito = false;
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "DELETE FROM users  WHERE username = @username ";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@username", id);



                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    exito = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }

            return exito;
        }

        public List<Usuario> findAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            String sql = "SELECT * FROM users";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                {
                    usuario = new Usuario();
                    usuario.Username = mysqlReader.GetString("username");
                    usuario.Password = mysqlReader.GetString("password");
                    usuario.Role = mysqlReader.GetString("role");
                    usuario.Active = mysqlReader.GetInt32("active");
                    usuarios.Add(usuario);
                }
                mysqlReader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }
            return usuarios;
        }

        public Usuario findById(string id)
        {
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "SELECT * FROM users WHERE  username = @username";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@username", id);

                using (MySqlDataReader reader = mysqlCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        usuario = new Usuario();
                        usuario.Username = reader.GetString("username");
                        usuario.Password = reader.GetString("password");
                        usuario.Role = reader.GetString("role");
                        usuario.Active = reader.GetInt32("active");


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }
            return usuario;
        }

        public bool save(Usuario dao)
        {
          
            bool exito = false;
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "INSERT INTO users (username , password , role , active ) VALUES (@username , @password , @role , @active )";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@username", dao.Username);
                mysqlCmd.Parameters.AddWithValue("@password", dao.Password);
                mysqlCmd.Parameters.AddWithValue("@role", dao.Role);
                mysqlCmd.Parameters.AddWithValue("@active", dao.Active);


                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    exito = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }

            return exito;
        }

        public bool update(Usuario dao)
        {
            bool exito = false;
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "UPDATE users SET   password=@password , role=@role , active=@active WHERE username = @username ";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@username", dao.Username);
                mysqlCmd.Parameters.AddWithValue("@password", dao.Password);
                mysqlCmd.Parameters.AddWithValue("@role", dao.Role);
                mysqlCmd.Parameters.AddWithValue("@active", dao.Active);


                if (mysqlCmd.ExecuteNonQuery() > 0)
                {
                    exito = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }

            return exito;
        }

        public DataTable LoadAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            String sql = "SELECT * FROM users";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query

                datos = new DataTable();
                mysqlDAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlDAdapter.Fill(datos);

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlDAdapter != null) mysqlDAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return datos;
        }

        public DataTable LoadAdapterByRole(String role)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            String sql = "SELECT * FROM users WHERE role = @role;";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query
                mysqlCmd.Parameters.AddWithValue("@role", role);
                datos = new DataTable();
                mysqlDAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlDAdapter.Fill(datos);

            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.ToString());
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlDAdapter != null) mysqlDAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return datos;
        }
    }
}
