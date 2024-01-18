using Autofac;
using MODEL;
using MODEL.Contracts;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Diagnostics;
using System.Linq;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopManagementWinformApp
{
    public partial class AppMainForm : Form
    {
        private IEnumerable<IProduct>? _products;
        private long _page = 0;
        public AppMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProductTable(refillProduct: true);
                hPageScrollBar.Value = (int)_page;
                txbPage.Text = (_page + 1).ToString();
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
            var filteredProducts = _products?.Take(new Range((Index)(15 * _page), (Index)(15 * _page + 15)));
            var properties = typeof(IProduct).GetProperties();
            if (filteredProducts?.Count() > 0)
            {
                for (var i = 0; i < filteredProducts.Count(); i++)
                {
                    IProduct? product = Program._cbInstance?.Resolve<IProduct>();
                    foreach (var p in properties)
                    {
                        p.SetValue(product, p.GetValue(filteredProducts.ElementAt((int)i)));
                    }
                    properties.FirstOrDefault(x => x.Name == "ID")?.SetValue(product, 15 * _page + i + 1);
                    bindingSource1.Add(product);
                }
            }

            btnInsert.Location = new System.Drawing.Point(0, 35 * (filteredProducts!.Count() + 1));

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
                        if (_products!.Count() % 15 == 1 && _page > 0)
                            ChangePageValue(_page - 1);
                        LoadProductTable(refillProduct: true);
                    }
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("updateBtn"))
                {
                    LoadAddForm(product);
                }
            }
        }

        private void TablePanelButton_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button clickedButton)
            {
                clickedButton.BackColor = ColorTranslator.FromHtml("#099268");
                clickedButton.ForeColor = ColorTranslator.FromHtml("#e6fcf5");
                foreach (var btn in tableLayoutPanelSelect.Controls.OfType<System.Windows.Forms.Button>().Where(x => x.Name != clickedButton.Name))
                {
                    btn.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    btn.ForeColor = ColorTranslator.FromHtml("#18492C");
                }
                if (clickedButton.Name == "btnProduct")
                    LoadProductTable(refillProduct: true);
            }
        }

        private void HPageScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if ((_products!.Count() - 1) / 15 >= hPageScrollBar.Value)
            {
                _page = hPageScrollBar.Value;
                txbPage.Text = (_page + 1).ToString();
                LoadProductTable();
            }
            else
            {
                hPageScrollBar.Value = (int)_page;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            LoadAddForm();
        }

        private void LoadAddForm(IProduct? product = null)
        {
            bool refillProduct = false;
            using AddForm addForm = new(product);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                ChangePageValue(_products!.Count() / 15);
                refillProduct = true;
            }

            LoadProductTable(refillProduct: refillProduct);
        }

        private void ChangePageValue(long value)
        {
            _page = value;
            hPageScrollBar.Value = (int)_page;
            txbPage.Text = (hPageScrollBar.Value + 1).ToString();
        }
    }

    internal record struct NewStruct(int Item1, int Item2)
    {
        public static implicit operator (int, int)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((int, int) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
