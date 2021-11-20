using System;

namespace Modelo
{
    public class Ficha
    {
        private int nhc;
        private String fechaVisita;
        private String especialista;
        private String motivo;
        private String preinscripción;
        
        public Ficha()
        {
     
        }
        
        public Ficha(int nhc, String fechaVisita, String especialista, String motivo, String preinscripción)
        {
            this.nhc = nhc;
            this.fechaVisita = fechaVisita;
            this.especialista = especialista;
            this.motivo = motivo;
            this.preinscripción = preinscripción;
        }
        
        public int Nhc
        {
            get { return nhc; }
            set { nhc = value; }
        }
        
        public String FechaVisita
        {
            get { return fechaVisita; }
            set { fechaVisita = value; }
        }
        
        public String Especialista
        {
            get { return especialista; }
            set { especialista = value; }
        }
        
        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        
        public String Preinscripción
        {
            get { return preinscripción; }
            set { preinscripción = value; }
        }
        
       
        public override string ToString()
        {
            return nhc+":"+fechaVisita+":"+especialista+":"+motivo+":"+preinscripción;
        }

    }
}