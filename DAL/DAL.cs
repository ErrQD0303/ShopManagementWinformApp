using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CONNECTIONS;
using System.Text;
using System.Threading.Tasks;
using CONNECTIONS.Contracts;
using Config;
using MODEL.Contracts;
using System.Data;
using Autofac;

namespace DAL
{
    public abstract class DAL<T> : IDAL<T>
        where T : class
    {
        #region fields
        protected ISQLConnection? _connection;
        #endregion
        #region constructor
        public DAL(ISQLConnection? connection) => _connection = connection ?? throw new ArgumentNullException();
        #endregion
        #region methods
        public async Task<T?> Get(Expression<Func<T, bool>>? filter = null)
        {
            try
            {
                var result = await GetAll(filter: filter, offset: 0, limit: -1);

                return result?.FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAll(long offset, long limit, Expression<Func<T, bool>>? filter = null)
        {
            try
            {
                if (_connection is null)
                    throw new ArgumentNullException();
                StringBuilder query = new StringBuilder("SELECT * FROM " + typeof(T).Name.Substring(1));
                object[]? parameterizedArray = null;
                if (filter != null)
                {
                    var lambda = filter.Compile();
                    (var whereClause, parameterizedArray) = filter.ToSqlWhereWithParameters();
                    query.Append(" WHERE " + whereClause);
                }

                if (limit > 0)
                {
                    query.Append($" LIMIT {limit}");
                }

                if (offset > 0)
                    query.Append($" OFFSET {offset}");

                return _connection.LoadData(query.ToString(), parameterizedArray).Tables[0].Rows.Cast<DataRow>().Select(Config.Configuration.CreateObject<T>);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public abstract Task Add(T entity);

        public abstract Task Remove(int id);

        public abstract Task Update(T entity);
        #endregion
    }
}
