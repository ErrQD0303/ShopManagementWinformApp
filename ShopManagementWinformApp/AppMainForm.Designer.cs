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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            panel1 = new Panel();
            txbPage = new TextBox();
            hPageScrollBar = new HScrollBar();
            label2 = new Label();
            btnInsert = new Button();
            label1 = new Label();
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
            panel1.BackColor = Color.FromArgb(23, 68, 109);
            panel1.Controls.Add(txbPage);
            panel1.Controls.Add(hPageScrollBar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 102);
            panel1.TabIndex = 2;
            // 
            // txbPage
            // 
            txbPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbPage.ForeColor = Color.FromArgb(77, 77, 77);
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
            label2.ForeColor = Color.FromArgb(235, 235, 235);
            label2.Location = new Point(907, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 2;
            label2.Text = "Page:";
            // 
            // btnInsert
            // 
            btnInsert.FlatAppearance.BorderSize = 2;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.FromArgb(235, 235, 235);
            btnInsert.Location = new Point(1154, 64);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 33);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += this.BtnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 235, 235);
            label1.Location = new Point(53, 17);
            label1.Name = "label1";
            label1.Size = new Size(520, 54);
            label1.TabIndex = 0;
            label1.Text = "SHOP MANAGEMENT APP";
            // 
            // panel2
            // 
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(77, 77, 77);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ProductDataGridView.ColumnHeadersHeight = 35;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, productIDDataGridViewTextBoxColumn, ProductName, descriptionDataGridViewTextBoxColumn, updateBtn, deleteBtn });
            ProductDataGridView.Cursor = Cursors.Hand;
            ProductDataGridView.DataSource = bindingSource1;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(77, 77, 77);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = SystemColors.ControlDark;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Margin = new Padding(0);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ProductDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 77, 0);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            updateBtn.DefaultCellStyle = dataGridViewCellStyle9;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.HeaderText = "";
            updateBtn.MinimumWidth = 6;
            updateBtn.Name = "updateBtn";
            updateBtn.ReadOnly = true;
            updateBtn.Resizable = DataGridViewTriState.False;
            updateBtn.Text = "➕UPDATE";
            updateBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(138, 0, 0);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            deleteBtn.DefaultCellStyle = dataGridViewCellStyle10;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.HeaderText = "";
            deleteBtn.MinimumWidth = 6;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ReadOnly = true;
            deleteBtn.Resizable = DataGridViewTriState.False;
            deleteBtn.Text = "➖DELETE";
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
            btnTest.ForeColor = Color.FromArgb(77, 77, 77);
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
            btnProduct.ForeColor = Color.FromArgb(77, 77, 77);
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
