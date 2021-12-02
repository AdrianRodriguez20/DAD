using Modelo.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ado
{
       public class UsuarioADO : Crud<Usuario, String>
        {
        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> findAll()
        {
            throw new NotImplementedException();
        }

        public Usuario findById(string id)
        {
            throw new NotImplementedException();
        }

        public void save(Usuario dao)
        {
            throw new NotImplementedException();
        }

        public bool update(Usuario dao)
        {
            throw new NotImplementedException();
        }
    }
}
