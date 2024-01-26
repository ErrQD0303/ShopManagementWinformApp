using Autofac;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MODEL;
using MODEL.Contracts;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopManagementWinformApp
{
    public partial class AppMainForm : Form
    {
        private event Action<long?> ChangedPageValue;
        private event Action<string> OnDataChanged;

        private IEnumerable<IProduct>? _products;
        private long _page = 0;
        private ISignalRServer? _signalRServer;
        private IProduct _filterProduct;
        public AppMainForm()
        {
            /*Random Comment*/
            InitializeComponent();
            ChangedPageValue += ChangePageValue;
            _signalRServer = Program.CBInstance.Resolve<ISignalRServer>();
            _filterProduct = Program.CBInstance.Resolve<IProduct>();
            OnDataChanged += PopupMessage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _signalRServer?.Start();
                _signalRServer!.AddMessage += (user, message) =>
                {
                    this.Invoke(() => OnDataChanged.Invoke(message));
                    this.Invoke(() => LoadProductTable(refillProduct: true));
                };
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
            if (ProductDataGridView.Rows.Count > 0)
                ProductDataGridView.Rows.Clear();

            if (refillProduct)
            {
                string productID = _filterProduct.ProductID ?? String.Empty;
                string productName = _filterProduct.ProductName ?? String.Empty;
                string description = _filterProduct.Description ?? String.Empty;
                _products = Program._unitOfWork?.ProductBLL
                    ?.GetAll(filter: x => x.IsActived && !x.IsDeleted
                    && x.ProductID.Contains(productID)
                    && x.ProductName.Contains(productName)
                    && x.Description.Contains(description),
                    offset: 15 * _page, limit: 15, filterObject: _filterProduct).Result;
            }

            if (_products!.Count() == 0 && _page > 0)
            {
                --hPageScrollBar.Value;
                _page = hPageScrollBar.Value;
                return;
            }

            var properties = typeof(IProduct).GetProperties();
            if (_products?.Count() > 0)
            {
                for (var i = 0; i < _products.Count(); i++)
                {
                    IProduct? product = Program.CBInstance?.Resolve<IProduct>();
                    foreach (var p in properties)
                    {
                        p.SetValue(product, p.GetValue(_products.ElementAt((int)i)));
                    }
                    properties.FirstOrDefault(x => x.Name == "DisplayID")?.SetValue(product, 15 * _page + i + 1);
                    bindingSource1.Add(product);
                }
            }

            btnInsert.Location = new System.Drawing.Point(0, 35 * (_products!.Count() + 1));

            ProductDataGridView.ClearSelection();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string? message = null;

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
                        if (_products!.Count() == 1 && _page > 0)
                            ChangePageValue(_page - 1);
                        LoadProductTable(refillProduct: true);
                    }
                    message = "Deleted";
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("updateBtn"))
                {
                    UpdateButton_Click(sender, e);
                    message = "Updated";
                }
                OnDataChangedInvoke(product, message!);
            }
        }

        private void UpdateButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = sender as DataGridView;
                var product = (IProduct)senderGrid!.Rows[e.RowIndex].DataBoundItem;
                LoadAddForm(product);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("This product has been updated by another user. Please reload the page.", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateButton_Click(sender, e);
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
            _page = hPageScrollBar.Value;
            LoadProductTable(true);
            txbPage.Text = (_page + 1).ToString();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            LoadAddForm();
        }

        private void LoadAddForm(IProduct? product = null)
        {
            try
            {
                using AddForm addForm = new(product);
                addForm.ShowDialog(this);
                if (addForm.DialogResult == DialogResult.Abort)
                {
                    throw new DBConcurrencyException();
                }
            }
            finally
            {
                LoadProductTable(refillProduct: true);
            }
        }

        private void ChangePageValue(long? value)
        {
            if (value == null && _products!.Count() == 15)
                _page += 1;
            else
                _page = value.Value;
            hPageScrollBar.Value = (int)_page;
            txbPage.Text = (hPageScrollBar.Value + 1).ToString();
        }

        public void ChangedPageValueInvoke()
        {
            ChangedPageValue?.Invoke(null);
        }

        public void OnDataChangedInvoke(object? o, string message)
        {
            if (o is not null && o is IProduct product)
            {
                message = $"{product.ProductID} {message}";
            }

            _signalRServer!.Send("user", message);
        }

        private void PopupMessage(string? message)
        {
            InformationPopUpForm informationPopUpForm = new(message);
            informationPopUpForm.Show(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show((System.Windows.Forms.Button)sender, new Point(0, btnMenuProductName.Height));
        }

        private void filterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripFilterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = toolStripFilterTextBox.Text;

                var buttonName = contextMenuStrip1.SourceControl?.Name.Substring(7);

                if (buttonName == "ProductID")
                {
                    _filterProduct.ProductID = filter;
                }
                else if (buttonName == "ProductName")
                {
                    _filterProduct.ProductName = filter;
                }
                else if (buttonName == "ProductDescription")
                {
                    _filterProduct.Description = filter;
                }

                LoadProductTable(refillProduct: true);
                return;

            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var buttonName = contextMenuStrip1.SourceControl?.Name.Substring(7);

            if (buttonName == "ProductID")
            {
                toolStripFilterTextBox.Text = _filterProduct.ProductID ?? String.Empty;
            }
            else if (buttonName == "ProductName")
            {
                toolStripFilterTextBox.Text = _filterProduct.ProductName ?? String.Empty;
            }
            else if (buttonName == "ProductDescription")
            {
                toolStripFilterTextBox.Text = _filterProduct.Description ?? String.Empty;
            }
        }
    }
}
