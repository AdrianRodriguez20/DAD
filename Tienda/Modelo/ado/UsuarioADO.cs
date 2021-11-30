using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;

namespace Modelo.ado
{
    public class UsuarioADO : Crud<Usuario, int>
    {
        private static DBConnection dataSource;

        public UsuarioADO()
        {
            dataSource = DBConnection.getInstance();
        }

        public void save(Usuario dao)
        {
            throw new NotImplementedException();
        }

        public Usuario findById(int id)
        {
            Usuario usuario = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM users WHERE id_staff = @numberStaff";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@numberStaff", id);
                using (MySqlDataReader reader = mysqlCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario();
                        usuario.NumberStaff = reader.GetInt32(0);
                        usuario.Password = reader.GetString(1);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error "+ e.ToString());
            }  finally
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

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> findAll()
        {
            throw new NotImplementedException();
        }
    }
}