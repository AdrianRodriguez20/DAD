using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.ado;
using Modelo.modelo;

namespace Controlador
{
    public class CategoriaController
    {
        
        CategoriaADO categoriaADO = new CategoriaADO();
        
        public List<String> listarCategorias()
        {

            List<Categoria> listaCategorias = null;
  
            if (categoriaADO.findAll()!=null)
            {
           
             listaCategorias = categoriaADO.findAll();
            }
      
            List<String> listaCategoriasStr = new List<String>();
            if (listaCategorias != null)
            {
                foreach (Categoria categoria in listaCategorias)
                {
                    listaCategoriasStr.Add(categoria.Tipo);
                }
            }


            return listaCategoriasStr;
        }
    }
}
