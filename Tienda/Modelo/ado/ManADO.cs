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
    public class ManADO : Crud<Man, int>
    {
        private static DBConnection dataSource;

        public ManADO()
        {
            dataSource = DBConnection.getInstance();
        }

        public void save(Man dao)
        {
            throw new NotImplementedException();
        }

        public Man findById(int id)
        {
            Man man = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM man WHERE id = @id";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = mysqlCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        man = new Man();
                        man.Id = reader.GetInt32(0);
                        man.Name = reader.GetString(1);
                        man.Category = reader.GetString(2);
                        man.Description = reader.GetString(3);
                        man.Price = reader.GetDouble(4);
                        man.Quantity = reader.GetInt32(5);
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
            return man;
        }

        public bool update(Man dao)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Man> findAll()
        {
            throw new NotImplementedException();
        }

        
        public DataTable LoadDataAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM man;";
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
        
        
        public DataTable LoadDataAdapterByCategory(String category)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM man WHERE category = @category;";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query
                mysqlCmd.Parameters.AddWithValue("@category", category);
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