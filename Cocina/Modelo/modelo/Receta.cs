using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Receta
    {
        private int id;
        private String name;
        private String category;
        private int time;
        private String ingredients;
        private String description;

        public Receta()
        {
        }

        public Receta(int id, string name, string category, int time, string ingredients, string description)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.time = time;
            this.ingredients = ingredients;
            this.description = description;
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

        public string Category
        {
            get => category;
            set => category = value;
        }

        public int Time
        {
            get => time;
            set => time = value;
        }

        public string Ingredients
        {
            get => ingredients;
            set => ingredients = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}