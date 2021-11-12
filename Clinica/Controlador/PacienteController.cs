using Modelo;
using System;
namespace Controlador
{
    public class PacienteController
    {
        PacienteDAO pacienteDAO = new PacienteDAO("pacientes.txt");
        
        public void AgregarPaciente(String nombre, String apellidos, String direccion, String codigoPostal, String poblacion, String dni, String nhc )
        {
            if(dni!=null && !dni.Trim().Equals("") && 
               nhc!=null && !nhc.Trim().Equals("") && 
               nombre!=null && !nombre.Trim().Equals("") && 
               apellidos!=null && !apellidos.Trim().Equals("") && 
               direccion!=null && !direccion.Trim().Equals("") && 
               poblacion!=null && !poblacion.Trim().Equals(""))
            {
                if (validarDni(dni) && validarNhc(nhc))
                {
                    Paciente paciente = new Paciente( nombre,  apellidos, direccion, Convert.ToInt32(codigoPostal), 
                        poblacion,  dni, Convert.ToInt32( nhc));
                    pacienteDAO.save(paciente);
                }

            }
       
        }

        private bool validarDni(String dni)
        {
 
            bool resultado = dni.Length ==9;

            return resultado;
        }
        private bool validarNhc(String nhc)
        {
            var nhcValid = int.TryParse(nhc, out int nhcInt);

            return nhcValid;
        }
        
    }
}