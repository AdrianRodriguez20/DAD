using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Man
    {
        private int id;
        private String name;
        private String category;
        private String description;
        private double price;
        private int quantity;

        public Man()
        {
        }

        public Man(int id, String name, String category,String description, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return id+": "+name+" - "+category+" - "+description+" - "+price+" - "+quantity;
        }
    }
}
