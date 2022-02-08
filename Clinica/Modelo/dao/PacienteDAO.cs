using System;
using System.Collections.Generic;
using System.IO;

namespace Modelo
{
    public class PacienteDAO : Crud<Paciente, String>
    {
        private GestorFichero gf;

        public PacienteDAO(GestorFichero gf)
        {
            this.gf = gf;
        }

        /**
 * Función que devuelve una lista con todos los pacientes de la tabla
 * 
 */
        public List<Paciente> findAll()
        {
            List<Paciente> pacientes = new List<Paciente>();
            try
            {
                StreamReader sr = new StreamReader(gf.Ruta);
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    String[] campos = linea.Split(':');
                    pacientes.Add(
                        new Paciente(
                            campos[0],campos[1],campos[2],
                            Convert.ToInt32(campos[3]),campos[4],campos[5],Convert.ToInt32(campos[6])
                            ) 
                    );
                    
                } 
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return pacientes;
        }

        /**
 * Función para insertar un paciente 
 * 
 */
        public void save(Paciente paciente)
        {

            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta, true);
                sw.WriteLine(paciente.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }      
        /**
         * Función para actualizar un paciente
         * 
         */

        public bool update(Paciente paciente)
        {
            List<Paciente> pacientes = findAll();
            bool exito=false;
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta);
                foreach (Paciente p in pacientes)
                {
                    if (p.Dni.Equals(paciente.Dni))
                    {
                        sw.WriteLine(paciente.ToString());
                        exito = true;
                    }
                    else
                    {
                        sw.WriteLine(p.ToString());
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
        /**
        * Función para eliminar un un paciente a través del dni
        * 
        */

        public bool delete(String id)
        {
            List<Paciente> pacientes = findAll();
            bool exito=false;
            try
            {
                StreamWriter sw = new StreamWriter(gf.Ruta);
                foreach (Paciente p in pacientes)
                {
                    if (!p.Dni.Equals(id))
                    {
                        sw.WriteLine(p.ToString());
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

        /**
         * Función que devuelve un paciente a través del dni
         * 
         */
        
        public Paciente findById(String dni)
        {
            List<Paciente> pacientes = findAll();
            Paciente paciente = null;
            foreach (Paciente p in pacientes)
            {
                if (p.Dni.Equals(dni))
                {
                    paciente =p;
                }
            }
            return paciente;
        }
        /**
 * Función que devuelve un paciente a través del nhc
 * 
 */

        public Paciente findByNhc(int nhc)
        {
            List<Paciente> pacientes = findAll();
            foreach (Paciente p in pacientes)
            {
                if (p.Nhc.Equals(nhc))
                {
                    return p;
                }
            }
            return null;
        }

        /**
  * Función que devuelve una lista de  pacientes con coincidencia de dni a través del dni
  * 
  */
        public List<Paciente> findBydIdParcial(String dni)
        {
            List<Paciente> pacientes = findAll();
            List<Paciente> concidencia = new List<Paciente>();
            
            foreach (Paciente p in pacientes)
            {
                if (p.Dni.ToString().Length >= dni.Length)
                {
                    if (p.Dni.Substring(0, dni.Length).Equals(dni.Substring(0, dni.Length)))
                    {
                        concidencia.Add(p);
                    }
                }
            }
            return concidencia;
        }

        /**
* Función que devuelve una lista de  pacientes con coincidencia de nhc a través del nhc
* 
*/
        public List<Paciente> findByNhcParcial(String nhc)
        {
            List<Paciente> pacientes = findAll();
            List<Paciente> concidencia = new List<Paciente>();

            foreach (Paciente p in pacientes)
            {
                if (p.Nhc.ToString().Length >= nhc.Length)
                {
                    if (p.Nhc.ToString().Substring(0, nhc.Length).Equals(nhc.Substring(0, nhc.Length)))
                    {
                        concidencia.Add(p);
                    }
                }
          
            }
            return concidencia;
        }
    }
}