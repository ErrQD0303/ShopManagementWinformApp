using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementWinformApp
{
    public partial class InformationPopUpForm : Form
    {
        private System.Windows.Forms.Timer closeTimer;

        public InformationPopUpForm(string? message)
        {
            InitializeComponent();
            Text = message ?? "No message";

            CloseAfterDelay(5000);
        }

        private async Task CloseAfterDelay(int millisecondsDelay)
        {
            await Task.Delay(millisecondsDelay);

            if (!this.IsDisposed && this.InvokeRequired)
            {
                this.Invoke(() => this.Close());
            }

            this.Close();
        }

        private void InformationPopUpForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Owner!.Location.X + 1068, Owner!.Location.Y + 37);
        }
    }
}
