namespace Northwind.WebFormsUI
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
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbx = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txbProductNameNewProduct = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbCategoryNewProduct = new System.Windows.Forms.ComboBox();
			this.txbPriceNewProduct = new System.Windows.Forms.TextBox();
			this.txbStockQuantityNewProduct = new System.Windows.Forms.TextBox();
			this.txbUnitQuantityNewProduct = new System.Windows.Forms.TextBox();
			this.btnAddNewProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(12, 163);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.RowTemplate.Height = 25;
			this.dgwProduct.Size = new System.Drawing.Size(687, 323);
			this.dgwProduct.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCategory);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 64);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Category Search";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(132, 27);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(180, 23);
			this.cmbCategory.TabIndex = 1;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Category";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbx);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 82);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(687, 75);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Product name search";
			// 
			// tbx
			// 
			this.tbx.Location = new System.Drawing.Point(132, 30);
			this.tbx.Name = "tbx";
			this.tbx.Size = new System.Drawing.Size(180, 23);
			this.tbx.TabIndex = 1;
			this.tbx.TextChanged += new System.EventHandler(this.tbx_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Product Name";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnAddNewProduct);
			this.groupBox3.Controls.Add(this.txbUnitQuantityNewProduct);
			this.groupBox3.Controls.Add(this.txbStockQuantityNewProduct);
			this.groupBox3.Controls.Add(this.txbPriceNewProduct);
			this.groupBox3.Controls.Add(this.cmbCategoryNewProduct);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txbProductNameNewProduct);
			this.groupBox3.Location = new System.Drawing.Point(705, 163);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(303, 323);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Add New Product";
			// 
			// txbProductNameNewProduct
			// 
			this.txbProductNameNewProduct.Location = new System.Drawing.Point(105, 38);
			this.txbProductNameNewProduct.Name = "txbProductNameNewProduct";
			this.txbProductNameNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbProductNameNewProduct.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Product Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "Category";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "Stock Quantity";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 15);
			this.label7.TabIndex = 5;
			this.label7.Text = "Unit Quantity";
			// 
			// cmbCategoryNewProduct
			// 
			this.cmbCategoryNewProduct.FormattingEnabled = true;
			this.cmbCategoryNewProduct.Location = new System.Drawing.Point(105, 92);
			this.cmbCategoryNewProduct.Name = "cmbCategoryNewProduct";
			this.cmbCategoryNewProduct.Size = new System.Drawing.Size(169, 23);
			this.cmbCategoryNewProduct.TabIndex = 6;
			// 
			// txbPriceNewProduct
			// 
			this.txbPriceNewProduct.Location = new System.Drawing.Point(105, 143);
			this.txbPriceNewProduct.Name = "txbPriceNewProduct";
			this.txbPriceNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbPriceNewProduct.TabIndex = 7;
			// 
			// txbStockQuantityNewProduct
			// 
			this.txbStockQuantityNewProduct.Location = new System.Drawing.Point(105, 187);
			this.txbStockQuantityNewProduct.Name = "txbStockQuantityNewProduct";
			this.txbStockQuantityNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbStockQuantityNewProduct.TabIndex = 8;
			// 
			// txbUnitQuantityNewProduct
			// 
			this.txbUnitQuantityNewProduct.Location = new System.Drawing.Point(105, 235);
			this.txbUnitQuantityNewProduct.Name = "txbUnitQuantityNewProduct";
			this.txbUnitQuantityNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbUnitQuantityNewProduct.TabIndex = 9;
			// 
			// btnAddNewProduct
			// 
			this.btnAddNewProduct.Location = new System.Drawing.Point(153, 264);
			this.btnAddNewProduct.Name = "btnAddNewProduct";
			this.btnAddNewProduct.Size = new System.Drawing.Size(75, 23);
			this.btnAddNewProduct.TabIndex = 10;
			this.btnAddNewProduct.Text = "Add";
			this.btnAddNewProduct.UseVisualStyleBackColor = true;
			this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1724, 559);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgwProduct;
		private GroupBox groupBox1;
		private ComboBox cmbCategory;
		private Label label1;
		private GroupBox groupBox2;
		private TextBox tbx;
		private Label label2;
		private GroupBox groupBox3;
		private Button btnAddNewProduct;
		private TextBox txbUnitQuantityNewProduct;
		private TextBox txbStockQuantityNewProduct;
		private TextBox txbPriceNewProduct;
		private ComboBox cmbCategoryNewProduct;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txbProductNameNewProduct;
	}
}