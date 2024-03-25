using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Repositories
{
    public interface IRespositories<T> where T : class, new()
    {
        List<T> GetAll();
        T GetEntity(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);

        /*Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);*/
    }
}
