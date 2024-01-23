using CONNECTIONS.Contracts;
using DAL.Contracts;
using MODEL;
using MODEL.Contracts;
using System.Reflection;
using System.Text;

namespace DAL
{
    public class ProductDAL : DAL<IProduct>, IProductDAL
    {
        public ProductDAL(ISQLConnection? connection) : base(connection)
        {
        }

        public async override Task Add(IProduct entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            await Execute(entity, "INSERT INTO PRODUCT ({0}) VALUES ({1})");
        }

        private async Task Execute(IProduct entity, string queryStr)
        {
            var properties = typeof(IProduct).GetProperties()
                .Where(x => !(x.Name == nameof(IProduct.DisplayID) || x.Name == nameof(IProduct.IsActived) || x.Name == nameof(IProduct.IsDeleted) || x.Name == nameof(IProduct.Version))).ToArray();
            if (properties.Length == 0)
                throw new ArgumentException(nameof(properties));
            string propertiesString = string.Empty;
            string valueString = string.Empty;
            object[] parameters = new object[properties.Length + 3];
            var count = 0;
            for (var i = 0; i < properties.Length; i++)
            {
                propertiesString += properties[i].Name + ", ";
                valueString += $"@p{count}, ";
                parameters[count] = properties[i].GetValue(entity);
                ++count;
            }
            propertiesString += "IsDeleted, IsActived, Version";
            valueString += $"@p{count}, @p{count + 1}, @p{count + 2}";
            parameters[count] = false;
            parameters[count + 1] = true;
            parameters[count + 2] = 1;
            var query = String.Format(queryStr, propertiesString, valueString);
            await _connection!.Execute(query, parameters);
        }

        public async override Task Remove(int id)
        {
            await _connection!.Execute($"Update Product Set IsDeleted = 1 WHERE Id = {id}");
        }

        public async override Task Update(IProduct entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            var str = $"UPDATE Product SET {{0}} WHERE Id = {entity.ID}";
            StringBuilder sb = new StringBuilder();
            var properties = typeof(IProduct).GetProperties().Where(x => !x.Name.Contains("ID") || x.Name == nameof(IProduct.Version)).ToArray();
            object[]? parameters = new object[properties.Length + 1];
            for (var i = 0; i < properties.Length; ++i)
            {
                sb.Append($"{properties[i].Name} = @p{i}, ");
                parameters[i] = properties[i].GetValue(entity);
            }

            sb.Append($"{nameof(IProduct.Version)} = @p{properties.Length}");
            parameters[properties.Length] = entity.Version + 1;
            var query = string.Format(str, sb.ToString());
            await _connection!.Execute(query, parameters);
        }
    }
}
