using DAL.Contracts;
using MODEL;

namespace DAL
{
    public class ProductDAL : DAL<Product>, IProductDAL
    {
        public override Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public override Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
