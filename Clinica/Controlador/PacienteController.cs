using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controlador
{
    public class PacienteController
    {
        PacienteDAO pacienteDAO = new PacienteDAO(new GestorFichero("pacientes.txt"));
        
        public bool AgregarPaciente(String nombre, String apellidos, String direccion, String codigoPostal, String poblacion, String dni, String nhc )
        {
            bool exito = false;
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
                    exito = true;
                }
            }

            return exito;

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
        public List<string[]> listarPacienteConcidencia(String opcion , String contenido)
        {
            List<Paciente> pacientes=null;
            if (opcion.Equals("DNI"))
            {
                pacientes= pacienteDAO.findBydIdParcial(contenido);
            }
            else if(opcion.Equals("NHC"))
            {
                pacientes = pacienteDAO.findByNhcParcial(contenido);
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
        
        public bool eliminarPaciente(String dni)
        {
            if (dni != null && !dni.Trim().Equals(""))
            {
               if (pacienteDAO.delete(dni))
                {
                    return true;
                }
            }
            return false;
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