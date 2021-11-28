using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Categoria
    {
        private String tipo;

        public Categoria()
        {
        }

        public Categoria(string tipo)
        {
            this.tipo = tipo;
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        
    }
}
