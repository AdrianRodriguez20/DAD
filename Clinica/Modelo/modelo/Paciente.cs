using System;

namespace Modelo
{
    public class Paciente
    {
        
        private String nombre;
        private String apellidos;
        private String direccion;
        private int codigoPostal;
        private String poblacion;   
        private String dni;
        private int nhc;
        
      /// <summary>
      /// Constructor vacio
      /// </summary>
        public Paciente(){ }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"> nombre del paciente</param>
        /// <param name="apellidos">apellidos del paciente</param>
        /// <param name="direccion">direccion del paciente</param>
        /// <param name="codigoPostal">codigo postal del paciente</param>
        /// <param name="poblacion">poblacion del paciente</param>
        /// <param name="dni">dni del paciente</param>
        /// <param name="nhc">nhc del paciente</param>
        public Paciente(String nombre, String apellidos, String direccion, int codigoPostal, String poblacion, String dni, int nhc)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.poblacion = poblacion;
            this.dni = dni;
            this.nhc = nhc;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public int CodigoPostal
        {
            get => codigoPostal;
            set => codigoPostal = value;
        }

        public string Poblacion
        {
            get => poblacion;
            set => poblacion = value;
        }

        public string Dni
        {
            get => dni;
            set => dni = value;
        }

        public int Nhc
        {
            get => nhc;
            set => nhc = value;
        }


        public override string ToString()
        {
            return  nombre+":"+apellidos+":"+direccion+":"+codigoPostal+":"+poblacion+":"+dni+":"+nhc;
        }
    }
}