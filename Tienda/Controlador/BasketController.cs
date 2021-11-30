using System.Data;
using Modelo.ado;
using Modelo.modelo;

namespace Controlador
{
    public class BasketController
    {
        public DataTable modelData;
        public BasketADO modelBaket;
        
        public BasketController()
        {
            modelBaket = new BasketADO();
        }
        
        public DataTable loadDataDA()
        {

            modelData = new DataTable();
            modelData = modelBaket.LoadDataAdapter();
            return modelData;
        }
        
        public bool insertBasket(int idProducto, int cantidad)
        {
            bool exito = false;
            ManADO manAdo = new ManADO();
            Man man = manAdo.findById(idProducto);
            if (cantidad < man.Quantity)
            {
                if (modelBaket.findById(man.Id) != null)
                {
                    Basket basket = modelBaket.findById(man.Id);
                    basket.Total += cantidad * man.Price;
                    modelBaket.update(basket);

                    man.Quantity = man.Quantity - cantidad;
                    manAdo.update(man);
                    exito = true;
                }
                else
                {
                    Basket basket = new Basket(man.Id, man.Name, cantidad * man.Price);
                    modelBaket.save(basket);
                    man.Quantity = man.Quantity - cantidad;
                    manAdo.update(man);
                    exito = true;
                }

            }

            return exito;
        }
        
        
    }
}