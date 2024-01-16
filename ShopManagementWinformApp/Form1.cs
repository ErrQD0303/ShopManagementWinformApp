using Autofac;
using MODEL.Contracts;
using System.Diagnostics;
using ZstdSharp.Unsafe;

namespace ShopManagementWinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProductTable();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void LoadProductTable()
        {
            ProductDataGridView.Rows.Clear();
            var products = Program._unitOfWork?.ProductBLL?.GetAll().Result;
            var filteredProducts = products?.Where(x => x.IsDeleted == false && x.IsActived == true);
            if (filteredProducts?.Count() > 0)
            {
                for (int i = 0; i < products.Count(); i++)
                {
                    IProduct? product = Program._cbInstance?.Resolve<IProduct>();
                    product!.ID = products.ElementAt(i).ID;
                    product!.ProductID = products.ElementAt(i).ProductID;
                    product!.ProductName = products.ElementAt(i).ProductName;
                    product!.Description = products.ElementAt(i).Description;
                    bindingSource1.Add(product);
                }
            }
        }
    }
}
