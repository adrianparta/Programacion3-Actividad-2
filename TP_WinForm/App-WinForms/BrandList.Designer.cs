namespace App_WinForms
{
    partial class BrandList
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
            this.dataGridViewBrands = new System.Windows.Forms.DataGridView();
            this.buttonUpdateBrand = new System.Windows.Forms.Button();
            this.buttonDeleteBrand = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.txtBrandDescription = new System.Windows.Forms.TextBox();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.lblBrandDescription = new System.Windows.Forms.Label();
            this.lblBrandId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBrands
            // 
            this.dataGridViewBrands.AllowUserToAddRows = false;
            this.dataGridViewBrands.AllowUserToDeleteRows = false;
            this.dataGridViewBrands.AllowUserToOrderColumns = true;
            this.dataGridViewBrands.AllowUserToResizeRows = false;
            this.dataGridViewBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrands.Location = new System.Drawing.Point(85, 57);
            this.dataGridViewBrands.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBrands.MultiSelect = false;
            this.dataGridViewBrands.Name = "dataGridViewBrands";
            this.dataGridViewBrands.ReadOnly = true;
            this.dataGridViewBrands.RowHeadersVisible = false;
            this.dataGridViewBrands.RowHeadersWidth = 51;
            this.dataGridViewBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrands.Size = new System.Drawing.Size(479, 247);
            this.dataGridViewBrands.TabIndex = 0;
            this.dataGridViewBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrands_CellClick);
            // 
            // buttonUpdateBrand
            // 
            this.buttonUpdateBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateBrand.Location = new System.Drawing.Point(623, 365);
            this.buttonUpdateBrand.Name = "buttonUpdateBrand";
            this.buttonUpdateBrand.Size = new System.Drawing.Size(100, 27);
            this.buttonUpdateBrand.TabIndex = 6;
            this.buttonUpdateBrand.Text = "Actualizar";
            this.buttonUpdateBrand.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteBrand.Location = new System.Drawing.Point(623, 140);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(100, 27);
            this.buttonDeleteBrand.TabIndex = 5;
            this.buttonDeleteBrand.Text = "Eliminar";
            this.buttonDeleteBrand.UseVisualStyleBackColor = true;
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBrand.Location = new System.Drawing.Point(623, 67);
            this.buttonAddBrand.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(100, 28);
            this.buttonAddBrand.TabIndex = 4;
            this.buttonAddBrand.Text = "Añadir";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            // 
            // txtBrandDescription
            // 
            this.txtBrandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrandDescription.Location = new System.Drawing.Point(302, 368);
            this.txtBrandDescription.Name = "txtBrandDescription";
            this.txtBrandDescription.Size = new System.Drawing.Size(262, 22);
            this.txtBrandDescription.TabIndex = 11;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrandId.Enabled = false;
            this.txtBrandId.Location = new System.Drawing.Point(116, 370);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(65, 22);
            this.txtBrandId.TabIndex = 10;
            // 
            // lblBrandDescription
            // 
            this.lblBrandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrandDescription.AutoSize = true;
            this.lblBrandDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandDescription.Location = new System.Drawing.Point(197, 370);
            this.lblBrandDescription.Name = "lblBrandDescription";
            this.lblBrandDescription.Size = new System.Drawing.Size(99, 20);
            this.lblBrandDescription.TabIndex = 9;
            this.lblBrandDescription.Text = "Descripcion";
            // 
            // lblBrandId
            // 
            this.lblBrandId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrandId.AutoSize = true;
            this.lblBrandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandId.Location = new System.Drawing.Point(84, 370);
            this.lblBrandId.Name = "lblBrandId";
            this.lblBrandId.Size = new System.Drawing.Size(26, 20);
            this.lblBrandId.TabIndex = 8;
            this.lblBrandId.Text = "ID";
            // 
            // BrandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 445);
            this.Controls.Add(this.txtBrandDescription);
            this.Controls.Add(this.txtBrandId);
            this.Controls.Add(this.lblBrandDescription);
            this.Controls.Add(this.lblBrandId);
            this.Controls.Add(this.buttonUpdateBrand);
            this.Controls.Add(this.buttonDeleteBrand);
            this.Controls.Add(this.buttonAddBrand);
            this.Controls.Add(this.dataGridViewBrands);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrandList";
            this.Text = "BrandList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrandList_FormClosing);
            this.Load += new System.EventHandler(this.BrandList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBrands;
        private System.Windows.Forms.Button buttonUpdateBrand;
        private System.Windows.Forms.Button buttonDeleteBrand;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.TextBox txtBrandDescription;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Label lblBrandDescription;
        private System.Windows.Forms.Label lblBrandId;
    }
}