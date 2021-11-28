using System;
using System.Collections.Generic;
using System.Data;
using Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.ado;
using Modelo.modelo;

namespace Controlador
{
    public class ManController
    {
        public DataTable modelData;
        public ManADO modelMan;
        
        public ManController()
        {
            modelMan = new ManADO();
        }
        
        public DataTable loadDataDA()
        {

            modelData = new DataTable();
            modelData = modelMan.LoadDataAdapter();
            return modelData;
        }
        
        public DataTable loadDataByCategoryDA(String category)
        {
            modelData = new DataTable();
            modelData = modelMan.LoadDataAdapterByCategory(category);
            return modelData;
        }

        public String[] findClotheProperties(int id)
        {
            String[] properties = new String[6];
            Man man = modelMan.findById(id);
            Console.WriteLine(man);
      
            if (man!=null)
            {
                properties[0] = man.Id.ToString();
                properties[1] = man.Name ;
                properties[2] = man.Category;
                properties[3] = man.Description;
                properties[4] = man.Price.ToString();
                properties[5] = man.Quantity.ToString();

            }
            
            return properties;
        }
        

    }
}
