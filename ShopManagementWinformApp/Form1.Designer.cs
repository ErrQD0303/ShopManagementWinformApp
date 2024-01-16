namespace ShopManagementWinformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ProductDataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            grb1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            grb1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AllowUserToResizeColumns = false;
            ProductDataGridView.AllowUserToResizeRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProductDataGridView.ColumnHeadersHeight = 30;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, productIDDataGridViewTextBoxColumn, ProductName, descriptionDataGridViewTextBoxColumn });
            ProductDataGridView.Cursor = Cursors.Hand;
            ProductDataGridView.DataSource = bindingSource1;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = SystemColors.ControlDark;
            ProductDataGridView.Location = new Point(3, 23);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProductDataGridView.RowTemplate.Height = 29;
            ProductDataGridView.Size = new Size(976, 599);
            ProductDataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.ReadOnly = true;
            productIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Resizable = DataGridViewTriState.False;
            ProductName.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            descriptionDataGridViewTextBoxColumn.Width = 591;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(MODEL.Product);
            // 
            // grb1
            // 
            grb1.Controls.Add(ProductDataGridView);
            grb1.Location = new Point(12, 84);
            grb1.Name = "grb1";
            grb1.Size = new Size(982, 625);
            grb1.TabIndex = 1;
            grb1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(grb1);
            Name = "Form1";
            Text = "Shop Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            grb1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductDataGridView;
        private BindingSource bindingSource1;
        private GroupBox grb1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
