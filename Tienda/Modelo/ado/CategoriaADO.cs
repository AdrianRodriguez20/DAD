using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.db;
using Modelo.modelo;
using MySql.Data.MySqlClient;

namespace Modelo.ado
{
    public class CategoriaADO : Crud <Categoria, String>
    {
        
        private static DBConnection dataSource;

        public CategoriaADO()
        {
            dataSource = DBConnection.getInstance();
        }
        
        public void save(Categoria dao)
        {
            throw new NotImplementedException();
        }

        public Categoria findById(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Categoria dao)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> findAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            MySqlConnection connection = null;
            MySqlDataReader mysqlReader = null;
            MySqlCommand mysqlCmd = null;
   
            string sql = "SELECT * FROM categories";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlReader = mysqlCmd.ExecuteReader();

                while (mysqlReader.Read())
                    {
                       Categoria categoria = new Categoria();
                        categoria.Tipo = mysqlReader.GetString(1);
                        categorias.Add(categoria);
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
            return categorias;
        }
        
        
    
    }
}
