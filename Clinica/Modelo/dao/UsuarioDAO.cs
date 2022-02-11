using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Modelo
{
    
    public class UsuarioDAO : Crud<Usuario, String>
    {
        private GestorFichero gf;

        public UsuarioDAO(GestorFichero gf)
        {
            this.gf = gf;
        }
        /// <summary>
        /// Función para insertar un usuario en el fichero
        /// <param name="usuario"> Usuario a insertar</param>
        /// </summary>

        public void save(Usuario usuario)
        {
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta, true);
                sw.WriteLine(usuario.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
  /// <summary>
  /// Función que devuelve una lista de usuarios
  /// </summary>
  /// <returns>lista de usuarios</returns>
        public List<Usuario> findAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                StreamReader sr = new StreamReader(gf.Ruta);
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    String[] campos = linea.Split(':');
                    usuarios.Add(
                        new Usuario(
                            campos[0],campos[1],campos[2]) 
                    );
                    
                } 
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return usuarios;
        }
        /// <summary>
        /// Función para actualizar un usuario en el fichero
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns> true o false , según el éxito de la operación</returns>
        public bool update(Usuario usuario)
        {
            List<Usuario> usuarios = findAll();
            bool exito = false;
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta);
                foreach (Usuario u in usuarios)
                {
                    if (u.User.Equals(usuario.User))
                    {
                        sw.WriteLine(usuario.ToString());
                        exito = true;
                    }
                    else
                    {
                        sw.WriteLine(u.ToString());
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return exito;
        }
        /// <summary>
        /// Función para eliminar un usuario a través del user
        /// </summary>
        /// <param name="user">nombre de usuario a eliminar"</param>
        public bool delete(String user)
        {
            List<Usuario> usuarios = findAll();
            bool exito = false;
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta);
                foreach (Usuario u in usuarios)
                {
                    if (!u.User.Equals(user))
                    {
                        sw.WriteLine(u.ToString());
                        exito=true;
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return exito;
        }

        /// <summary>
        /// Función que devuelve un usuario a través del nombre de usuario
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        public Usuario findById(String user)
        {
            List<Usuario> usuarios = findAll();
            foreach (Usuario u in usuarios)
            {
                if (u.User.Equals(user))
                {
                    return u;
                }
            }
            return null;
        }
        
        
        
    }
}