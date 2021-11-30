using System;
using System.Collections.Generic;
using System.Data;
using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;

namespace Modelo.ado
{
    class RecetaADO : Crud<Receta, int>
    {
        private static DBConnection dataSource;

        public RecetaADO()
        {
            dataSource = DBConnection.getInstance();
        }

        public bool save(Receta dao)
        {
            bool exito = false;
            Receta receta = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql ="INSERT INTO recipes (name , category , time , ingredients , description ) VALUES (@name , @category , @time , @ingredients , @description )";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@category", dao.Category);
                mysqlCmd.Parameters.AddWithValue("@time", dao.Time);
                mysqlCmd.Parameters.AddWithValue("@ingredients", dao.Ingredients);
                mysqlCmd.Parameters.AddWithValue("@description", dao.Description);

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

        public Receta findById(int id)
        {
            Receta receta = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "SELECT * FROM recipes WHERE id = @id";

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
                        receta = new Receta();
                        receta.Id = reader.GetInt32("id");
                        receta.Name = reader.GetString("name");
                        receta.Category = reader.GetString("category");
                        receta.Time = reader.GetInt32("time");
                        receta.Ingredients = reader.GetString("ingredients");
                        receta.Description = reader.GetString("description");

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
            return receta;
        }

        public bool update(Receta dao)
        {
            bool exito = false;
            Receta receta = null;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "UPDATE recipes SET name = @name , category = @category , time = @time , ingredients = @ingredients , description = @description WHERE id = @id";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@id", dao.Id);
                mysqlCmd.Parameters.AddWithValue("@name", dao.Name);
                mysqlCmd.Parameters.AddWithValue("@category", dao.Category);
                mysqlCmd.Parameters.AddWithValue("@time", dao.Time);
                mysqlCmd.Parameters.AddWithValue("@ingredients", dao.Ingredients);
                
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
            bool exito = false;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql = "DELETE FROM recipes WHERE id = @id";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlCmd.Parameters.AddWithValue("@id", id);

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

        public List<Receta> findAll()
        {
            List<Receta> recetas = new List<Receta>();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;
            String sql = "SELECT * FROM recipes";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                {
                    Receta receta = new Receta();
                    receta.Id = mysqlReader.GetInt32("id");
                    receta.Name = mysqlReader.GetString("name");
                    receta.Category = mysqlReader.GetString("category");
                    receta.Time = mysqlReader.GetInt32("time");
                    receta.Ingredients = mysqlReader.GetString("ingredients");
                    receta.Description = mysqlReader.GetString("description");
                    recetas.Add(receta);
                }
                mysqlReader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("error "+ e.ToString());
            }  finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();
            }
            return recetas;

        }

        public DataTable LoadAdapter()
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlDAdapter = null;
            DataTable datos = null;
            String sql = "SELECT * FROM recipes";
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