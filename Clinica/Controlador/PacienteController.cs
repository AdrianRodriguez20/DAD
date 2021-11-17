using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controlador
{
    public class PacienteController
    {
        PacienteDAO pacienteDAO = new PacienteDAO(new GestorFichero("pacientes.txt"));
        
        public void AgregarPaciente(String nombre, String apellidos, String direccion, String codigoPostal, String poblacion, String dni, String nhc )
        {
            if(dni!=null && !dni.Trim().Equals("") && 
               nhc!=null && !nhc.Trim().Equals("") && 
               nombre!=null && !nombre.Trim().Equals("") && 
               apellidos!=null && !apellidos.Trim().Equals("") && 
               direccion!=null && !direccion.Trim().Equals("") && 
               poblacion!=null && !poblacion.Trim().Equals(""))
            {
                
                if (validarDni(dni) && validarNhc(nhc) && pacienteDAO.findById(dni)==null  && pacienteDAO.findByNhc(Convert.ToInt32(nhc))==null  )
                {
                    Paciente paciente = new Paciente( nombre,  apellidos, direccion, Convert.ToInt32(codigoPostal), 
                        poblacion,  dni, Convert.ToInt32( nhc));
                    pacienteDAO.save(paciente);
                }
            }
       
        }
        public List<string[]> listarPacientes()
        {
            List<Paciente> pacientes = pacienteDAO.findAll();
            List<string[]> pacientesStr = new List<string[]>(); ;
            if (pacienteDAO != null)
            {
                foreach (Paciente paciente in pacientes)
                {

                   pacientesStr.Add(new string[] {
                   paciente.Nombre,
                   paciente.Apellidos,
                   paciente.Direccion,
                   paciente.CodigoPostal+"",
                   paciente.Poblacion,
                   paciente.Dni,
                   paciente.Nhc + "" });

                }
            }

            return pacientesStr;
        }
        public List<string[]> listarPacienteConcidencia(String dni , String nhc)
        {
            List<Paciente> pacientes=null;
            if (dni!=null && !dni.Trim().Equals(""))
            {
                pacientes= pacienteDAO.findBydIdParcial(dni);
            }
            else if(nhc != null && !nhc.Trim().Equals(""))
            {
                pacientes = pacienteDAO.findByNhcParcial(nhc);
            }
            else
            {
                pacientes = pacienteDAO.findAll();
            }
            List<string[]> pacientesStr = new List<string[]>(); ;
            if (pacientes != null)
            {
                foreach (Paciente paciente in pacientes)
                {
                    pacientesStr.Add(new string[] { paciente.Nombre,
                   paciente.Apellidos,
                   paciente.Direccion,
                   paciente.CodigoPostal+"",
                   paciente.Poblacion,
                   paciente.Dni,
                   paciente.Nhc + "" });

                }
            }

            return pacientesStr;
        }
        private bool validarDni(String dni)
        {
 
            bool resultado = dni.Length ==9;
            return resultado;
        }
        private bool validarNhc(String nhc)
        {
           Regex regex = new Regex(@"^[0-9]{1,}$");
           bool resultado = regex.IsMatch(nhc);
           
           return resultado;
        }
        
    }
}