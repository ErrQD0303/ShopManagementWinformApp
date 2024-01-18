namespace ShopManagementWinformApp
{
    partial class AppMainForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            panel1 = new Panel();
            txbPage = new TextBox();
            hPageScrollBar = new HScrollBar();
            label2 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            panel2 = new Panel();
            ProductDataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            tableLayoutPanelSelect = new TableLayoutPanel();
            btnTest = new Button();
            btnProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            tableLayoutPanelSelect.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(MODEL.Product);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 166, 120);
            panel1.Controls.Add(txbPage);
            panel1.Controls.Add(hPageScrollBar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 102);
            panel1.TabIndex = 2;
            // 
            // txbPage
            // 
            txbPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbPage.ForeColor = Color.FromArgb(24, 73, 44);
            txbPage.Location = new Point(999, 64);
            txbPage.Margin = new Padding(0);
            txbPage.Name = "txbPage";
            txbPage.Size = new Size(37, 34);
            txbPage.TabIndex = 4;
            txbPage.TextAlign = HorizontalAlignment.Center;
            // 
            // hPageScrollBar
            // 
            hPageScrollBar.Location = new Point(979, 64);
            hPageScrollBar.Maximum = 10000;
            hPageScrollBar.Name = "hPageScrollBar";
            hPageScrollBar.Size = new Size(76, 33);
            hPageScrollBar.TabIndex = 3;
            hPageScrollBar.TabStop = true;
            hPageScrollBar.ValueChanged += HPageScrollBar_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 252, 245);
            label2.Location = new Point(907, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 2;
            label2.Text = "Page:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 252, 245);
            label1.Location = new Point(53, 17);
            label1.Name = "label1";
            label1.Size = new Size(520, 54);
            label1.TabIndex = 0;
            label1.Text = "SHOP MANAGEMENT APP";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(12, 166, 120);
            btnInsert.FlatAppearance.BorderSize = 2;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.FromArgb(230, 252, 245);
            btnInsert.Location = new Point(0, 35);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 35);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "➕";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += BtnInsert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(ProductDataGridView);
            panel2.Location = new Point(243, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 598);
            panel2.TabIndex = 3;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AllowUserToResizeColumns = false;
            ProductDataGridView.AllowUserToResizeRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.BackgroundColor = SystemColors.Control;
            ProductDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(24, 73, 44);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(24, 73, 44);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductDataGridView.ColumnHeadersHeight = 35;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, productIDDataGridViewTextBoxColumn, ProductName, descriptionDataGridViewTextBoxColumn, updateBtn, deleteBtn });
            ProductDataGridView.Cursor = Cursors.Hand;
            ProductDataGridView.DataSource = bindingSource1;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(24, 73, 44);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(8, 127, 91);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(230, 252, 245);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.EnableHeadersVisualStyles = false;
            ProductDataGridView.GridColor = SystemColors.ControlDark;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Margin = new Padding(0);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(24, 73, 44);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(24, 73, 44);
            ProductDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProductDataGridView.RowTemplate.Height = 35;
            ProductDataGridView.ScrollBars = ScrollBars.None;
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGridView.Size = new Size(1005, 598);
            ProductDataGridView.TabIndex = 2;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
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
            productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.ReadOnly = true;
            productIDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Resizable = DataGridViewTriState.False;
            ProductName.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            descriptionDataGridViewTextBoxColumn.Width = 350;
            // 
            // updateBtn
            // 
            updateBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(8, 127, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(230, 252, 245);
            updateBtn.DefaultCellStyle = dataGridViewCellStyle2;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.HeaderText = "";
            updateBtn.MinimumWidth = 6;
            updateBtn.Name = "updateBtn";
            updateBtn.ReadOnly = true;
            updateBtn.Resizable = DataGridViewTriState.False;
            updateBtn.Text = "🔃UPDATE";
            updateBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 49, 49);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 245, 245);
            deleteBtn.DefaultCellStyle = dataGridViewCellStyle3;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.HeaderText = "";
            deleteBtn.MinimumWidth = 6;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ReadOnly = true;
            deleteBtn.Resizable = DataGridViewTriState.False;
            deleteBtn.Text = "🗑DELETE";
            deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanelSelect
            // 
            tableLayoutPanelSelect.ColumnCount = 1;
            tableLayoutPanelSelect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelect.Controls.Add(btnTest, 0, 1);
            tableLayoutPanelSelect.Controls.Add(btnProduct, 0, 0);
            tableLayoutPanelSelect.Location = new Point(-1, 101);
            tableLayoutPanelSelect.Name = "tableLayoutPanelSelect";
            tableLayoutPanelSelect.RowCount = 3;
            tableLayoutPanelSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelSelect.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelSelect.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelect.Size = new Size(243, 599);
            tableLayoutPanelSelect.TabIndex = 4;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.White;
            btnTest.Dock = DockStyle.Fill;
            btnTest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.ForeColor = Color.FromArgb(24, 73, 44);
            btnTest.Location = new Point(0, 35);
            btnTest.Margin = new Padding(0);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(243, 35);
            btnTest.TabIndex = 1;
            btnTest.Text = "TEST BUTTON";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += TablePanelButton_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.Dock = DockStyle.Fill;
            btnProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.FromArgb(24, 73, 44);
            btnProduct.Location = new Point(0, 0);
            btnProduct.Margin = new Padding(0);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(243, 35);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "PRODUCT";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += TablePanelButton_Click;
            // 
            // AppMainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1248, 693);
            Controls.Add(tableLayoutPanelSelect);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AppMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            tableLayoutPanelSelect.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private Panel panel1;
        private Button btnInsert;
        private Label label1;
        private Panel panel2;
        private DataGridView ProductDataGridView;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanelSelect;
        private Button btnProduct;
        private Button btnTest;
        private Label label2;
        private HScrollBar hPageScrollBar;
        private TextBox txbPage;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
    }
}
