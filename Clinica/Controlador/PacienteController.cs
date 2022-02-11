using Modelo;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controlador
{
    public class PacienteController
    {
        PacienteDAO pacienteDAO = new PacienteDAO(new GestorFichero("pacientes.txt"));
        
        /// <summary>
        /// Función para añadir un paciente a la lista de pacientes
        /// </summary>
        /// <param name="nombre"> nombre del paciente</param>
        /// <param name="apellidos">apellidos del paciente</param>
        /// <param name="direccion">dirección del paciente</param>
        /// <param name="codigoPostal">código postal del paciente</param>
        /// <param name="poblacion"> población del paciente</param>
        /// <param name="dni"> dni del paciente</param>
        /// <param name="nhc">nhc del paciente</param>
        /// <returns> Devuelve True si la insercion se ha realizado correctamente, False en caso contrario</returns>
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
        
        /// <summary>
        ///  Función que devuelve una lista de pacientes
        /// </summary>
        /// <returns> lista de pacientes</returns>
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
       
        /// <summary>
        /// Función que devuelve una lista de pacientes según coincidencia
        /// </summary>
        /// <param name="opcion">opción de filtrado , dni o nhc</param>
        /// <param name="contenido">valor de la busqueda</param>
        /// <returns>Lista de pacientes con coincidencia</returns>
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
        
        /// <summary>
        /// Función para eliminar un paciente
        /// </summary>
        /// <param name="dni">dni del paciente</param>
        /// <returns>Devuelve True si la eliminación se ha realizado correctamente, False en caso contrario</returns>
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
        
        /// <summary>
        /// Función para validar el dni
        /// </summary>
        /// <param name="dni"> dni del paciente </param>
        /// <returns>Devuelve True si el dni es correcto, False en caso contrario</returns>
        private bool validarDni(String dni)
        {
 
            bool resultado = dni.Length ==9;
            return resultado;
        }
        
        /// <summary>
        /// Función para validar el nhc
        /// </summary>
        /// <param name="nhc">nhc del paciente</param>
        /// <returns> Devuelve true si el nhc es correcto, false en caso contrario</returns>
        private bool validarNhc(String nhc)
        {
           Regex regex = new Regex(@"^[0-9]{1,}$");
           bool resultado = regex.IsMatch(nhc);
           
           return resultado;
        }
        
    }
}