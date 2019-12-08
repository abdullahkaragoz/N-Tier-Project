namespace Northwind.WinUI.Forms
{
    partial class FormProducts
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
            this.dgvGetProducts = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.txtPCategoryId = new System.Windows.Forms.TextBox();
            this.lblPCategoryId = new System.Windows.Forms.Label();
            this.btnProductShow = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.txtDiscontinued = new System.Windows.Forms.TextBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetProducts
            // 
            this.dgvGetProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetProducts.Location = new System.Drawing.Point(4, 213);
            this.dgvGetProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGetProducts.Name = "dgvGetProducts";
            this.dgvGetProducts.Size = new System.Drawing.Size(738, 264);
            this.dgvGetProducts.TabIndex = 30;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(122, 11);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(89, 23);
            this.txtProductId.TabIndex = 28;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(16, 14);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(74, 17);
            this.lblProductId.TabIndex = 20;
            this.lblProductId.Text = "Product ID";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(368, 87);
            this.txtQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(120, 23);
            this.txtQuantityPerUnit.TabIndex = 32;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(252, 90);
            this.lblQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(108, 17);
            this.lblQuantityPerUnit.TabIndex = 31;
            this.lblQuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(368, 12);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(120, 23);
            this.txtSupplierId.TabIndex = 34;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(283, 15);
            this.lblSupplierId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(77, 17);
            this.lblSupplierId.TabIndex = 33;
            this.lblSupplierId.Text = "Supplier ID";
            // 
            // txtPCategoryId
            // 
            this.txtPCategoryId.Location = new System.Drawing.Point(609, 12);
            this.txtPCategoryId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPCategoryId.Name = "txtPCategoryId";
            this.txtPCategoryId.Size = new System.Drawing.Size(120, 23);
            this.txtPCategoryId.TabIndex = 36;
            // 
            // lblPCategoryId
            // 
            this.lblPCategoryId.AutoSize = true;
            this.lblPCategoryId.Location = new System.Drawing.Point(500, 16);
            this.lblPCategoryId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCategoryId.Name = "lblPCategoryId";
            this.lblPCategoryId.Size = new System.Drawing.Size(82, 17);
            this.lblPCategoryId.TabIndex = 35;
            this.lblPCategoryId.Text = "Category ID";
            // 
            // btnProductShow
            // 
            this.btnProductShow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProductShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductShow.Location = new System.Drawing.Point(592, 145);
            this.btnProductShow.Name = "btnProductShow";
            this.btnProductShow.Size = new System.Drawing.Size(137, 61);
            this.btnProductShow.TabIndex = 37;
            this.btnProductShow.Text = "GÖSTER";
            this.btnProductShow.UseVisualStyleBackColor = false;
            this.btnProductShow.Click += new System.EventHandler(this.BtnProductShow_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(368, 51);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(120, 23);
            this.txtUnitPrice.TabIndex = 39;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(295, 54);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 17);
            this.lblUnitPrice.TabIndex = 38;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(609, 52);
            this.txtUnitsInStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(120, 23);
            this.txtUnitsInStock.TabIndex = 41;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(500, 56);
            this.lblUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(86, 17);
            this.lblUnitsInStock.TabIndex = 40;
            this.lblUnitsInStock.Text = "UnitsInStock";
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(604, 90);
            this.txtUnitsOnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(125, 23);
            this.txtUnitsOnOrder.TabIndex = 43;
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(493, 90);
            this.lblUnitsOnOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(96, 17);
            this.lblUnitsOnOrder.TabIndex = 42;
            this.lblUnitsOnOrder.Text = "UnitsOnOrder";
            // 
            // txtDiscontinued
            // 
            this.txtDiscontinued.Location = new System.Drawing.Point(118, 115);
            this.txtDiscontinued.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscontinued.Name = "txtDiscontinued";
            this.txtDiscontinued.Size = new System.Drawing.Size(120, 23);
            this.txtDiscontinued.TabIndex = 45;
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(20, 118);
            this.lblDiscontinued.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(90, 17);
            this.lblDiscontinued.TabIndex = 44;
            this.lblDiscontinued.Text = "Discontinued";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(118, 84);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(120, 23);
            this.txtReorderLevel.TabIndex = 47;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(16, 87);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(94, 17);
            this.lblReorderLevel.TabIndex = 46;
            this.lblReorderLevel.Text = "ReorderLevel";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdateProduct.Location = new System.Drawing.Point(400, 156);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(170, 50);
            this.btnUpdateProduct.TabIndex = 50;
            this.btnUpdateProduct.Text = "Ürün Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDeleteProduct.Location = new System.Drawing.Point(206, 156);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(188, 50);
            this.btnDeleteProduct.TabIndex = 49;
            this.btnDeleteProduct.Text = "Ürün Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 156);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(188, 50);
            this.btnAddProduct.TabIndex = 48;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(122, 48);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(116, 23);
            this.txtProductName.TabIndex = 52;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 51);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 51;
            this.lblProductName.Text = "Product Name";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 477);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.txtDiscontinued);
            this.Controls.Add(this.lblDiscontinued);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.btnProductShow);
            this.Controls.Add(this.txtPCategoryId);
            this.Controls.Add(this.lblPCategoryId);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.dgvGetProducts);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetProducts;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.TextBox txtPCategoryId;
        private System.Windows.Forms.Label lblPCategoryId;
        private System.Windows.Forms.Button btnProductShow;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.TextBox txtDiscontinued;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
    }
}