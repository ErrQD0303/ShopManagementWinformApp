using Autofac;
using MODEL.Contracts;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Diagnostics;
using ZstdSharp.Unsafe;

namespace ShopManagementWinformApp
{
    public partial class Form1 : Form
    {
        private IEnumerable<IProduct>? _products;
        private long _page = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProductTable(refillProduct: true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void LoadProductTable(bool refillProduct = false)
        {
            ProductDataGridView.Rows.Clear();
            var products = Program._unitOfWork?.ProductBLL?.GetAll().Result;
            if (refillProduct)
                _products = products?.Where(x => x.IsDeleted == false && x.IsActived == true);
            var filteredProducts = _products?.Take(new Range((Index)(10 * _page), (Index)(10 * _page + 15)));
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
            ProductDataGridView.ClearSelection();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var product = (IProduct)senderGrid.Rows[e.RowIndex].DataBoundItem;
                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("deleteBtn"))
                {
                    var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var databaseProduct = Program._unitOfWork?.ProductBLL?.Get(x => x.ProductID == product.ProductID).Result;
                        Program._unitOfWork?.ProductBLL?.Remove((int)databaseProduct!.ID);
                        LoadProductTable(refillProduct: true);
                    }
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("updateBtn"))
                {
                    /*var result = MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var updateProductForm = Program._cbInstance?.Resolve<UpdateProductForm>();
                        updateProductForm?.ShowDialog();
                        LoadProductTable();
                    }*/
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
