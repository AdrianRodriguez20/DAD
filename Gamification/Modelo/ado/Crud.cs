using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ado
{
    public interface Crud<T, E>
    {
        void save(T dao);

        T findById(E id);

        bool update(T dao);

        bool delete(E id);

        List<T> findAll();
    }
}
