namespace App_WinForms
{
    partial class CategoryList
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
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCateogryDescription = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtCaregoryDescription = new System.Windows.Forms.TextBox();
            this.txtCaregoryNew = new System.Windows.Forms.TextBox();
            this.lblCateogryNew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AllowUserToOrderColumns = true;
            this.dataGridViewCategories.AllowUserToResizeRows = false;
            this.dataGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(69, 82);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCategories.MultiSelect = false;
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersVisible = false;
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(480, 257);
            this.dataGridViewCategories.TabIndex = 0;
            this.dataGridViewCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellClick);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCategory.Location = new System.Drawing.Point(600, 32);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(100, 28);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "Añadir";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(600, 185);
            this.buttonDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(100, 27);
            this.buttonDeleteCategory.TabIndex = 2;
            this.buttonDeleteCategory.Text = "Eliminar";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateCategory.Location = new System.Drawing.Point(600, 354);
            this.buttonUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(100, 27);
            this.buttonUpdateCategory.TabIndex = 3;
            this.buttonUpdateCategory.Text = "Actualizar";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(69, 362);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(26, 20);
            this.lblCategoryId.TabIndex = 4;
            this.lblCategoryId.Text = "ID";
            // 
            // lblCateogryDescription
            // 
            this.lblCateogryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCateogryDescription.AutoSize = true;
            this.lblCateogryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateogryDescription.Location = new System.Drawing.Point(181, 362);
            this.lblCateogryDescription.Name = "lblCateogryDescription";
            this.lblCateogryDescription.Size = new System.Drawing.Size(99, 20);
            this.lblCateogryDescription.TabIndex = 5;
            this.lblCateogryDescription.Text = "Descripcion";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(101, 362);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryId.MaxLength = 50;
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(65, 22);
            this.txtCategoryId.TabIndex = 6;
            // 
            // txtCaregoryDescription
            // 
            this.txtCaregoryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaregoryDescription.Location = new System.Drawing.Point(287, 359);
            this.txtCaregoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaregoryDescription.MaxLength = 50;
            this.txtCaregoryDescription.Name = "txtCaregoryDescription";
            this.txtCaregoryDescription.Size = new System.Drawing.Size(263, 22);
            this.txtCaregoryDescription.TabIndex = 7;
            // 
            // txtCaregoryNew
            // 
            this.txtCaregoryNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaregoryNew.Location = new System.Drawing.Point(287, 37);
            this.txtCaregoryNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaregoryNew.MaxLength = 50;
            this.txtCaregoryNew.Name = "txtCaregoryNew";
            this.txtCaregoryNew.Size = new System.Drawing.Size(263, 22);
            this.txtCaregoryNew.TabIndex = 9;
            // 
            // lblCateogryNew
            // 
            this.lblCateogryNew.AutoSize = true;
            this.lblCateogryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateogryNew.Location = new System.Drawing.Point(65, 37);
            this.lblCateogryNew.Name = "lblCateogryNew";
            this.lblCateogryNew.Size = new System.Drawing.Size(194, 20);
            this.lblCateogryNew.TabIndex = 8;
            this.lblCateogryNew.Text = "Agregar nueva Categoria";
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.txtCaregoryNew);
            this.Controls.Add(this.lblCateogryNew);
            this.Controls.Add(this.txtCaregoryDescription);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.lblCateogryDescription);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.buttonUpdateCategory);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.dataGridViewCategories);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Categorias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryList_FormClosing);
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCateogryDescription;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtCaregoryDescription;
        private System.Windows.Forms.TextBox txtCaregoryNew;
        private System.Windows.Forms.Label lblCateogryNew;
    }
}