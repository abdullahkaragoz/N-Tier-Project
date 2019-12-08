namespace Northwind.WinUI.Forms
{
    partial class FormCategory
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.dgvGetCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddCategory.Location = new System.Drawing.Point(589, 62);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(188, 50);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Kategori Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(207, 122);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(350, 131);
            this.txtCategoryDescription.TabIndex = 12;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(7, 122);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(189, 26);
            this.lblCategoryDescription.TabIndex = 11;
            this.lblCategoryDescription.Text = "Kategori Açıklama";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(207, 77);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(350, 32);
            this.txtCategoryName.TabIndex = 10;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(65, 77);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(131, 26);
            this.lblCategoryName.TabIndex = 9;
            this.lblCategoryName.Text = "Kategori Adı";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(32, 20);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(169, 26);
            this.lblCategoryId.TabIndex = 8;
            this.lblCategoryId.Text = "Sıra Numarası : ";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDeleteCategory.Location = new System.Drawing.Point(589, 125);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(188, 50);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "Kategori Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.BtnRemoveCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdateCategory.Location = new System.Drawing.Point(589, 190);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(188, 63);
            this.btnUpdateCategory.TabIndex = 16;
            this.btnUpdateCategory.Text = "Kategori Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.BtnUpdateCategory_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(207, 20);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(68, 32);
            this.txtCategoryId.TabIndex = 17;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowCategory.Location = new System.Drawing.Point(783, 62);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(145, 191);
            this.btnShowCategory.TabIndex = 18;
            this.btnShowCategory.Text = "Göster";
            this.btnShowCategory.UseVisualStyleBackColor = false;
            this.btnShowCategory.Click += new System.EventHandler(this.BtnShowCategory_Click);
            // 
            // dgvGetCategories
            // 
            this.dgvGetCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetCategories.Location = new System.Drawing.Point(2, 259);
            this.dgvGetCategories.Name = "dgvGetCategories";
            this.dgvGetCategories.Size = new System.Drawing.Size(926, 349);
            this.dgvGetCategories.TabIndex = 19;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 608);
            this.Controls.Add(this.dgvGetCategories);
            this.Controls.Add(this.btnShowCategory);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.DataGridView dgvGetCategories;
    }
}