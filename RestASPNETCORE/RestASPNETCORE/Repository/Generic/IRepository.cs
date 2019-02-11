using RestASPNETCORE.Model.Base;
using System.Collections.Generic;

namespace RestASPNETCORE.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long Id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long Id);
        bool Exists(long? Id);
        List<T> FindWithPagedSearch(string query);
        int GetCount(string query);
    }
}
