using System.Collections.Generic;
using System.Data;

namespace Modelo.ado
{
    public interface Crud <T, E> 
    {
        bool save(T dao);

        T findById(E id);

        bool update(T dao);

        bool delete(E id);

        List<T> findAll();

        DataTable LoadAdapter();
    }
}