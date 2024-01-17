namespace ShopManagementWinformApp
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            richtxbInputProductDescription = new RichTextBox();
            lblInputDescription = new Label();
            lblInputProductName = new Label();
            txbInputProductName = new TextBox();
            btnAddUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richtxbInputProductDescription);
            splitContainer1.Panel2.Controls.Add(lblInputDescription);
            splitContainer1.Panel2.Controls.Add(lblInputProductName);
            splitContainer1.Panel2.Controls.Add(txbInputProductName);
            splitContainer1.Panel2.Controls.Add(btnAddUpdate);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1361, 551);
            splitContainer1.SplitterDistance = 160;
            splitContainer1.TabIndex = 0;
            // 
            // richtxbInputProductDescription
            // 
            richtxbInputProductDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richtxbInputProductDescription.Location = new Point(151, 130);
            richtxbInputProductDescription.Name = "richtxbInputProductDescription";
            richtxbInputProductDescription.ScrollBars = RichTextBoxScrollBars.Vertical;
            richtxbInputProductDescription.Size = new Size(398, 98);
            richtxbInputProductDescription.TabIndex = 3;
            richtxbInputProductDescription.Text = "";
            // 
            // lblInputDescription
            // 
            lblInputDescription.AutoSize = true;
            lblInputDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblInputDescription.Location = new Point(20, 130);
            lblInputDescription.Name = "lblInputDescription";
            lblInputDescription.Size = new Size(100, 23);
            lblInputDescription.TabIndex = 2;
            lblInputDescription.Text = "Description:";
            // 
            // lblInputProductName
            // 
            lblInputProductName.AutoSize = true;
            lblInputProductName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblInputProductName.Location = new Point(20, 46);
            lblInputProductName.Name = "lblInputProductName";
            lblInputProductName.Size = new Size(125, 23);
            lblInputProductName.TabIndex = 2;
            lblInputProductName.Text = "Product Name:";
            // 
            // txbInputProductName
            // 
            txbInputProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txbInputProductName.Location = new Point(151, 43);
            txbInputProductName.Name = "txbInputProductName";
            txbInputProductName.Size = new Size(179, 30);
            txbInputProductName.TabIndex = 1;
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.BackColor = Color.White;
            btnAddUpdate.FlatAppearance.BorderSize = 3;
            btnAddUpdate.FlatStyle = FlatStyle.Flat;
            btnAddUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUpdate.ForeColor = Color.Black;
            btnAddUpdate.Location = new Point(1013, 169);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(111, 45);
            btnAddUpdate.TabIndex = 0;
            btnAddUpdate.Text = "BUTTON";
            btnAddUpdate.UseVisualStyleBackColor = false;
            btnAddUpdate.Click += BtnAddUpdate_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 551);
            Controls.Add(splitContainer1);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddForm";
            Load += AddForm_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private Label lblInputProductName;
        private TextBox textBox2;
        private TextBox txbInputProductName;
        private Button btnAddUpdate;
        private RichTextBox richtxbInputProductDescription;
        private Label lblInputDescription;
    }
}