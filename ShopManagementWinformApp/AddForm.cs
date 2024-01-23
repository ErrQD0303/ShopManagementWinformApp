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
        private readonly IProduct? _product;
        public AddForm(IProduct? product = null)
        {
            InitializeComponent();
            _product = product;
        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_product is null)
                {
                    var product = Program.CBInstance?.Resolve<IProduct>();
                    product!.ProductName = txbInputProductName.Text;
                    product!.Description = richtxbInputProductDescription.Text;
                    Program._unitOfWork?.ProductBLL.Add(product);
                    if (Owner is AppMainForm amf)
                        amf.ChangedPageValueInvoke();
                }
                else
                {
                    var product = _product;
                    product!.ProductName = txbInputProductName.Text;
                    product!.Description = richtxbInputProductDescription.Text;
                    var t = Program._unitOfWork?.ProductBLL.Update(product);
                    if (t!.IsFaulted)
                    {
                        this.DialogResult = DialogResult.Abort;
                        return;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            finally
            {
                this.Close();
            }
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
