using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Modelo
{
    
    public class UsuarioDAO
    {
        private String ruta;

        public UsuarioDAO()
        {

        }

        public UsuarioDAO(String ruta)
        {
            this.ruta = ruta;
        }

        public void setRuta(String ruta)
        {
            this.ruta = ruta;
        }
        
        
        public List<Usuario> readAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                StreamReader sr = new StreamReader(ruta);
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
        
        public void update(Usuario usuario)
        {
            List<Usuario> usuarios = readAll();
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (Usuario u in usuarios)
                {
                    if (u.User.Equals(usuario.User))
                    {
                        sw.WriteLine(usuario.ToString());
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
        }
        
        public void delete(Usuario usuario)
        {
            List<Usuario> usuarios = readAll();
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (Usuario u in usuarios)
                {
                    if (!u.User.Equals(usuario.User))
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
        }
        
        public Usuario findById(String user)
        {
            List<Usuario> usuarios = readAll();
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