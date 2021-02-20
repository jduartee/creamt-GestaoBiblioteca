using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task Save(T tEntity);
        Task Update(int id, T tEntity);
        Task Delete(int id);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
