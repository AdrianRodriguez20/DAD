using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWPF
{
    public class Moneda
    {
        [JsonProperty("code")]
        private String nombre;

        [JsonProperty("rate")]
        private double valor;
        
        public Moneda(){}
        
        public Moneda(String nombre, double valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
        
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        
        public double Valor
        {
            get => valor;
            set => valor = value;
        }
        
        public override string ToString()
        {
            return nombre + ": " + valor;
        }
    }
}
