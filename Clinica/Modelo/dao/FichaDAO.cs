using System;
using System.Collections.Generic;
using System.IO;

namespace Modelo
{
    public class FichaDAO : Crud<Ficha, int>
    {
        private GestorFichero gf;

        public FichaDAO(GestorFichero gf)
        {
            this.gf = gf;
        }
/// <summary>
/// Medodo encargado de realizar la insercion
/// </summary>
/// <param name="dao">ficha</param>
        public void save(Ficha dao)
        {
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta, true);
                sw.WriteLine(dao.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        
        public Ficha findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(Ficha dao)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Función que devuelve una lista con todos las Fichas de la tabla
        /// </summary>
        /// <returns>Lista de fichas</returns>
        public List<Ficha> findAll()
        {
            List<Ficha> fichas = new List<Ficha>();
            try
            {
                StreamReader sr = new StreamReader(gf.Ruta);
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    String[] campos = linea.Split(':');
                    fichas.Add(
                        new Ficha(
                            Convert.ToInt32(campos[0]), campos[1], campos[2],
                            campos[3], campos[4])
                    );
                    
                } 
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return fichas;
        }
        /// <summary>
        /// Funcion que realiza la busqueda de una ficha traves de su nhc
        /// </summary>
        /// <param name="id">NHC del paciente</param>
        /// <returns>Lista de fichas</returns>

        public List<Ficha> findByNhc(int id)
        {
            List<Ficha> fichas = findAll();
            List<Ficha> fichasPaciente = new List<Ficha>();
            foreach (Ficha p in fichas)
            {
                if (p.Nhc.Equals(id))
                {
                   fichasPaciente.Add(p);
                }
            }
            return fichasPaciente;
        }
    }
}