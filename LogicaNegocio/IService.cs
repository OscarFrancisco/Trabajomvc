using System.Collections.Generic;

namespace LogicaNegocio
{
    public interface IService<T>
    {
        T Add(T entity);
        int Delete(T entity);
        int Update(T entity);
        T Get(T entity);
        IEnumerable<T> GetAll();
    }
}
