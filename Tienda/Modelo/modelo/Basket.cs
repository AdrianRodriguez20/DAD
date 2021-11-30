using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Basket
    {
        private int id;
        private String name;
        private Double total;
        
        public Basket()
        {

        }
        
        public Basket(int id, String name, Double total)
        {
            this.id = id;
            this.name = name;
            this.total = total;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }
    }
}
