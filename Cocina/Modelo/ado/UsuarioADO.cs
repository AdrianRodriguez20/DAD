using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;

namespace Modelo.ado
{
    public class UsuarioADO : Crud<Usuario, String>
    {
        private static DBConnection dataSource;
        
        public UsuarioADO()
        {
            dataSource = DBConnection.getInstance();
        }
        public bool save(Usuario dao)
        {
            throw new NotImplementedException();
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

        public bool update(Usuario dao)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> findAll()
        {
            throw new NotImplementedException();
        }

        public DataTable LoadAdapter()
        {
            throw new NotImplementedException();
        }
    }
}
