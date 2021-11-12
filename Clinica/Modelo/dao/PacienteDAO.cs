using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Modelo
{
    public class PacienteDAO
    {
        private String ruta;

        public PacienteDAO()
        {
        }

        public PacienteDAO(String ruta)
        {
            this.ruta = ruta;
        }

        public void setRuta(String ruta)
        {
            this.ruta = ruta;
        }

       
        public List<Paciente> readAll()
        {
            List<Paciente> pacientes = new List<Paciente>();
            try
            {
                StreamReader sr = new StreamReader(ruta);
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

        public void save(Paciente paciente)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(paciente.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        
        public void update(Paciente paciente)
        {
            List<Paciente> pacientes = readAll();
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (Paciente p in pacientes)
                {
                    if (p.Dni.Equals(paciente.Dni))
                    {
                        sw.WriteLine(paciente.ToString());
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
        }
        
        public void delete(Paciente paciente)
        {
            List<Paciente> pacientes = readAll();
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (Paciente p in pacientes)
                {
                    if (!p.Dni.Equals(paciente.Dni))
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
        }
        
        public Paciente findById(String dni)
        {
            List<Paciente> pacientes = readAll();
            foreach (Paciente p in pacientes)
            {
                if (p.Dni.Equals(dni))
                {
                    return p;
                }
            }
            return null;
        }
        
        public Paciente findByNhc(int nhc)
        {
            List<Paciente> pacientes = readAll();
            foreach (Paciente p in pacientes)
            {
                if (p.Nhc.Equals(nhc))
                {
                    return p;
                }
            }
            return null;
        }
        
       
    }
}