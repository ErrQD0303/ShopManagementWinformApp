using MODEL.Contracts;
using System.Configuration;

namespace MODEL
{
    public class Product : IProduct
    {
        #region fields
        private long _id;
        private string? _productID;
        private string? _productName;
        private string? _description;
        private bool _isActived;
        private bool _isDeleted;
        private long _displayID;
        private int _version;
        #endregion

        #region properties
        public long ID { get => _id; set => _id = value; }
        public string ProductID { get => _productID ?? throw new ArgumentNullException(); set => _productID = value; }
        public string ProductName { get => _productName ?? throw new ArgumentNullException(); set => _productName = value; }
        public string Description { get => _description ?? throw new ArgumentNullException(); set => _description = value; }
        public bool IsActived { get => _isActived; set => _isActived = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
        public long DisplayID { get => _displayID; set => _displayID = value; }
        public int Version { get => _version; set => _version = value; }
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
                ProductName = this.ProductName,
                Description = this.Description, 
                IsActived = this.IsActived,
                IsDeleted = this.IsDeleted, 
                DisplayID = this.DisplayID,
                Version = this.Version
            };
        }
        #endregion
    }
}
