using System.Collections.Generic;

namespace Modelo
{
  /// <summary>
  /// Interfaz con las acciones básicas de un crud
  /// </summary>

  public interface Crud <T, E> 
    {
        void save(T dao);

        T findById(E id);

        bool update(T dao);

        bool delete(E id);

        List<T> findAll();
    }
}  