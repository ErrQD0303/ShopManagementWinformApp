using MODEL.Contracts;
using System.Configuration;

namespace MODEL
{
    internal class Product : IProduct
    {
        #region fields
        private long _id;
        private string? _productID;
        private string? _name;
        private string? _description;
        private bool _isActived;
        private bool _isDeleted;
        #endregion

        #region properties
        public long ID { get => _id; set => _id = value; }
        public string ProductID { get => _productID ?? throw new ArgumentNullException(); set => _productID = value; }
        public string Name { get => _name ?? throw new ArgumentNullException(); set => _name = value; }
        public string Description { get => _description ?? throw new ArgumentNullException(); set => _description = value; }
        public bool IsActived { get => _isActived; set => _isActived = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
        #endregion

        #region constructors
        public Product() { }

        #endregion
        #region methods
        public object Clone()
        {
            return new Product()
            {
                ID = this.ID,
                ProductID = this.ProductID,
                Name = this.Name,
                Description = this.Description
            };
        }
        #endregion
    }
}
