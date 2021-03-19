using System.Collections.Generic;

namespace Core.Model
{
    public interface IRepository<T>
    {
        T GetT(int Id);
        List<T> List();
        int AddT(T entity);
        bool Delete(int Id);

    }
}
