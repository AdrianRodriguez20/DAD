using System;
using System.Collections.Generic;
using System.Data;
using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace Modelo.ado
{
    public class BasketADO : Crud<Basket,int>
    {
        
        private static DBConnection dataSource;
        
        public BasketADO()
        {
            dataSource = DBConnection.getInstance();
        }
        
        public void save(Basket dao)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            string sql = "INSERT INTO basket (id, name, total) VALUES (@id, @name, @total)";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@id", dao.Id);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@total", dao.Total);
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

        public Basket findById(int id)
        {

            Basket basket = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            string sql = "SELECT * FROM basket WHERE id = @id";

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
                        basket = new Basket();
                        basket.Id = reader.GetInt32(0);
                        basket.Name = reader.GetString(1);
                        basket.Total = reader.GetDouble(2);
                   
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
            return basket;
        }

        public bool update(Basket dao)
        {
            bool exito = false;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            string sql = "UPDATE basket SET name = @name, total = @total WHERE  id= @id";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);

                mysqlCmd.Parameters.AddWithValue("@id", dao.Id);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@total", dao.Total);

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

        public List<Basket> findAll()
        {
            throw new NotImplementedException();
        }
        
        
        public DataTable LoadDataAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            string sql = "SELECT * FROM basket;";
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
    }
}
