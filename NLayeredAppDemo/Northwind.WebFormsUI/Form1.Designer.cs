﻿namespace Northwind.WebFormsUI
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
			this.btnAddNewProduct = new System.Windows.Forms.Button();
			this.txbQuantityPerUnitNewProduct = new System.Windows.Forms.TextBox();
			this.txbUnitInStockQuantityNewProduct = new System.Windows.Forms.TextBox();
			this.txbUnitPriceNewProduct = new System.Windows.Forms.TextBox();
			this.cmbCategoryNewProduct = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txbProductNameNewProduct = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitInStockQuantityUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.cmbCategoryUpdate = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
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
			this.groupBox3.Controls.Add(this.txbQuantityPerUnitNewProduct);
			this.groupBox3.Controls.Add(this.txbUnitInStockQuantityNewProduct);
			this.groupBox3.Controls.Add(this.txbUnitPriceNewProduct);
			this.groupBox3.Controls.Add(this.cmbCategoryNewProduct);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txbProductNameNewProduct);
			this.groupBox3.Location = new System.Drawing.Point(705, 163);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(341, 323);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Add New Product";
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
			// txbQuantityPerUnitNewProduct
			// 
			this.txbQuantityPerUnitNewProduct.Location = new System.Drawing.Point(135, 187);
			this.txbQuantityPerUnitNewProduct.Name = "txbQuantityPerUnitNewProduct";
			this.txbQuantityPerUnitNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbQuantityPerUnitNewProduct.TabIndex = 9;
			// 
			// txbUnitInStockQuantityNewProduct
			// 
			this.txbUnitInStockQuantityNewProduct.Location = new System.Drawing.Point(134, 235);
			this.txbUnitInStockQuantityNewProduct.Name = "txbUnitInStockQuantityNewProduct";
			this.txbUnitInStockQuantityNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbUnitInStockQuantityNewProduct.TabIndex = 8;
			// 
			// txbUnitPriceNewProduct
			// 
			this.txbUnitPriceNewProduct.Location = new System.Drawing.Point(134, 143);
			this.txbUnitPriceNewProduct.Name = "txbUnitPriceNewProduct";
			this.txbUnitPriceNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbUnitPriceNewProduct.TabIndex = 7;
			// 
			// cmbCategoryNewProduct
			// 
			this.cmbCategoryNewProduct.FormattingEnabled = true;
			this.cmbCategoryNewProduct.Location = new System.Drawing.Point(134, 92);
			this.cmbCategoryNewProduct.Name = "cmbCategoryNewProduct";
			this.cmbCategoryNewProduct.Size = new System.Drawing.Size(169, 23);
			this.cmbCategoryNewProduct.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 15);
			this.label7.TabIndex = 5;
			this.label7.Text = "Quantity Per Unit";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 238);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "Unit In Stock Quantity";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Unit Price";
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Product Name";
			// 
			// txbProductNameNewProduct
			// 
			this.txbProductNameNewProduct.Location = new System.Drawing.Point(134, 38);
			this.txbProductNameNewProduct.Name = "txbProductNameNewProduct";
			this.txbProductNameNewProduct.Size = new System.Drawing.Size(169, 23);
			this.txbProductNameNewProduct.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnUpdateProduct);
			this.groupBox4.Controls.Add(this.tbxQuantityPerUnitUpdate);
			this.groupBox4.Controls.Add(this.tbxUnitInStockQuantityUpdate);
			this.groupBox4.Controls.Add(this.tbxUnitPriceUpdate);
			this.groupBox4.Controls.Add(this.cmbCategoryUpdate);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.tbxProductNameUpdate);
			this.groupBox4.Location = new System.Drawing.Point(1077, 163);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(341, 323);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Update Product";
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.Location = new System.Drawing.Point(175, 264);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(94, 23);
			this.btnUpdateProduct.TabIndex = 10;
			this.btnUpdateProduct.Text = "Update";
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// tbxQuantityPerUnitUpdate
			// 
			this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(135, 187);
			this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
			this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(169, 23);
			this.tbxQuantityPerUnitUpdate.TabIndex = 9;
			// 
			// tbxUnitInStockQuantityUpdate
			// 
			this.tbxUnitInStockQuantityUpdate.Location = new System.Drawing.Point(134, 235);
			this.tbxUnitInStockQuantityUpdate.Name = "tbxUnitInStockQuantityUpdate";
			this.tbxUnitInStockQuantityUpdate.Size = new System.Drawing.Size(169, 23);
			this.tbxUnitInStockQuantityUpdate.TabIndex = 8;
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(134, 143);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(169, 23);
			this.tbxUnitPriceUpdate.TabIndex = 7;
			// 
			// cmbCategoryUpdate
			// 
			this.cmbCategoryUpdate.FormattingEnabled = true;
			this.cmbCategoryUpdate.Location = new System.Drawing.Point(134, 92);
			this.cmbCategoryUpdate.Name = "cmbCategoryUpdate";
			this.cmbCategoryUpdate.Size = new System.Drawing.Size(169, 23);
			this.cmbCategoryUpdate.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 15);
			this.label8.TabIndex = 5;
			this.label8.Text = "Quantity Per Unit";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 238);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 15);
			this.label9.TabIndex = 4;
			this.label9.Text = "Unit In Stock Quantity";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "Unit Price";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 95);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 15);
			this.label11.TabIndex = 2;
			this.label11.Text = "Category";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 41);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 15);
			this.label12.TabIndex = 1;
			this.label12.Text = "Product Name";
			// 
			// tbxProductNameUpdate
			// 
			this.tbxProductNameUpdate.Location = new System.Drawing.Point(134, 38);
			this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
			this.tbxProductNameUpdate.Size = new System.Drawing.Size(169, 23);
			this.tbxProductNameUpdate.TabIndex = 0;
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Location = new System.Drawing.Point(705, 115);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(341, 39);
			this.btnRemoveProduct.TabIndex = 4;
			this.btnRemoveProduct.Text = "Remove Select Product";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1724, 559);
			this.Controls.Add(this.btnRemoveProduct);
			this.Controls.Add(this.groupBox4);
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
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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
		private TextBox txbQuantityPerUnitNewProduct;
		private TextBox txbUnitInStockQuantityNewProduct;
		private TextBox txbUnitPriceNewProduct;
		private ComboBox cmbCategoryNewProduct;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txbProductNameNewProduct;
		private GroupBox groupBox4;
		private TextBox tbxQuantityPerUnitUpdate;
		private TextBox tbxUnitInStockQuantityUpdate;
		private TextBox tbxUnitPriceUpdate;
		private ComboBox cmbCategoryUpdate;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private TextBox tbxProductNameUpdate;
		private Button btnUpdateProduct;
		private Button btnRemoveProduct;
	}
}