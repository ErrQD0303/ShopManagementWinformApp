using Autofac;
using BLL.Contracts;
using MODEL;
using MODEL.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementWinformApp
{
    public partial class AddForm : Form
    {
        private string? _callerMethodName;
        private readonly IProduct? _product;
        public AddForm(IProduct? product = null)
        {
            InitializeComponent();
            _product = product;
        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            if (_product is null)
            {
                var product = Program._cbInstance?.Resolve<IProduct>();
                product!.ProductName = txbInputProductName.Text;
                product!.Description = richtxbInputProductDescription.Text;
                Program._unitOfWork?.ProductBLL.Add(product);
            }
            else
            {
                var product = _product;
                product!.ProductName = txbInputProductName.Text;
                product!.Description = richtxbInputProductDescription.Text;
                Program._unitOfWork?.ProductBLL.Update(product);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (_product is null)
            {
                btnAddUpdate.Text = "ADD";
            }
            else
            {
                btnAddUpdate.Text = "UPDATE";
                txbInputProductName.Text = _product.ProductName;
                richtxbInputProductDescription.Text = _product.Description;
            }
        }
    }
}
