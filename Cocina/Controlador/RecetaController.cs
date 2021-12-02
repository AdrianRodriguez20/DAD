using Modelo.ado;
using Modelo.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class RecetaController
    {
        RecetaADO recetaADO = new RecetaADO();
        public DataTable modelData;
        public List<String> listarCategorias()
        {

            List<Receta> listaCategorias = null;

            if (recetaADO.findAll() != null)
            {

                listaCategorias = recetaADO.findAll();
            }

            List<String> listaCategoriasStr = new List<String>();
            if (listaCategorias != null)
            {
                foreach (Receta categoria in listaCategorias)
                {
                    listaCategoriasStr.Add(categoria.Category);
                }
            }


            return listaCategoriasStr;
        }

        public DataTable loadDataDA()
        {

            modelData = new DataTable();
            modelData = recetaADO.LoadAdapter();
            return modelData;
        }

        public DataTable loadDataByCategoryDA(String category)
        {
            modelData = new DataTable();
            modelData = recetaADO.LoadAdapterByCategory(category);
            return modelData;
        }

    }
}
