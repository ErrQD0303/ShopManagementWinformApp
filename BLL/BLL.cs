using BLL.Contracts;
using DAL.Contracts;
using MODEL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BLL<T> : IBLL<T>
        where T: class
    {
        #region Fields
        protected readonly IDAL<T>? _dal;
        #endregion

        #region Constructor
        public BLL(IDAL<T>? dal) => _dal = dal ?? throw new ArgumentNullException();
        #endregion

        #region Methods
        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null) 
            => _dal!.GetAll(filter);

        public Task<T> Get(Expression<Func<T, bool>>? filter = null)
            => _dal!.Get(filter);

        public abstract Task Add(T entity);

        public abstract Task Update(T entity);

        public abstract Task Remove(int id);
        #endregion
    }
}
