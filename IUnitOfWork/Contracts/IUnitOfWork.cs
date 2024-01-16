using BLL.Contracts;

namespace IUnitOfWork.Contracts
{
    public interface IUnitOfWork
    {
        public IProductBLL ProductBLL { get; set; }
    }
}
