using BLL.Contracts;
using IUnitOfWork.Contracts;

namespace IUnitOfWork
{
    public class UnitOfWork : IUnitOfWork.Contracts.IUnitOfWork
    {
        private IProductBLL? _productBLL;
        public IProductBLL? ProductBLL { get => _productBLL; set => _productBLL = value; }

        public UnitOfWork(IProductBLL? productBLL) {
            ProductBLL = productBLL ?? throw new ArgumentNullException(nameof(productBLL));
        }
    }
}
