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
            var properties = typeof(IProduct).GetProperties();
            if (filteredProducts?.Count() > 0)
            {
                for (int i = 0; i < filteredProducts.Count(); i++)
                {
                    IProduct? product = Program._cbInstance?.Resolve<IProduct>();
                    foreach (var p in properties)
                    {
                        p.SetValue(product, p.GetValue(filteredProducts.ElementAt(i)));
                    }
                    properties.FirstOrDefault(x => x.Name == "ID")?.SetValue(product, i + 1);
                    bindingSource1.Add(product);
                }
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
