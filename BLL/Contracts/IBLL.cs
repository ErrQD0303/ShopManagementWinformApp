using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IBLL<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll(long offset = 0, long limit = 0, Expression<Func<T, bool>>? filter = null);
        Task<T?> Get(Expression<Func<T, bool>>? filter = null);
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(int id);
    }
}
