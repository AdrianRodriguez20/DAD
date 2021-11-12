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
        
      
        public Paciente(){ }
        
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