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
            Man man = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            string sql = "INSERT INTO catman (id, name, category, description , price , quantity) VALUES (@id ,@name , @category @description, @price, @quantity)";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@id", dao.Id);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@category", dao.Category);
                mysqlCmd.Parameters.AddWithValue("@description", dao.Description);
                mysqlCmd.Parameters.AddWithValue("@price", dao.Price);
                mysqlCmd.Parameters.AddWithValue("@quantity", dao.Quantity);

                mysqlCmd.ExecuteNonQuery();
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
        }

        public Man findById(int id)
        {
            Man man = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            string sql = "SELECT * FROM catman WHERE id = @id";

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
            bool exito = false;
            Man man = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "UPDATE catman SET  name =@name , category =@category , description=@description , price=@price , quantity=@quantity WHERE id =@id";
            
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                
                mysqlCmd.Parameters.AddWithValue("@id", dao.Id);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@category", dao.Category);
                mysqlCmd.Parameters.AddWithValue("@description", dao.Description);
                mysqlCmd.Parameters.AddWithValue("@price", dao.Price);
                mysqlCmd.Parameters.AddWithValue("@quantity", dao.Quantity);
                
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
            string sql = "SELECT * FROM catman;";
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
            string sql = "SELECT * FROM catman WHERE category = @category;";
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