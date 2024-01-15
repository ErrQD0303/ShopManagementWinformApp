using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CONNECTIONS;
using System.Text;
using System.Threading.Tasks;
using CONNECTIONS.Contracts;
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
        public async Task<T> Get(Expression<Func<T, bool>>? filter = null)
        {
            try
            {
                if (_connection is null)
                    throw new ArgumentNullException();

                StringBuilder query = new StringBuilder("SELECT * FROM " + typeof(T).Name.Substring(1));
                if (filter != null)
                {
                    var lambda = filter.Compile();
                    var whereClause = Expressio
                    query.Append(" WHERE " + whereClause);
                }
                var resultRows = _connection.LoadData(query.ToString()).Tables[0].Rows.Cast<DataRow>().ToList();
                T result = Config.Configuration.CB.Build().Resolve<T>();
                var propertiesName = result.GetType().GetProperties().Select(x => x.Name).ToList();
                foreach (var item in propertiesName)
                {
                    typeof(T).GetProperty(item)?.SetValue(result, resultRow[item]);
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            try
            {
                if (_connection is null)
                    throw new ArgumentNullException();
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
