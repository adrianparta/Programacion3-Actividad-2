﻿namespace App_WinForms
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
            this.txtBrandNew = new System.Windows.Forms.TextBox();
            this.lblBrandNew = new System.Windows.Forms.Label();
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
            this.dataGridViewBrands.Location = new System.Drawing.Point(64, 64);
            this.dataGridViewBrands.MultiSelect = false;
            this.dataGridViewBrands.Name = "dataGridViewBrands";
            this.dataGridViewBrands.ReadOnly = true;
            this.dataGridViewBrands.RowHeadersVisible = false;
            this.dataGridViewBrands.RowHeadersWidth = 51;
            this.dataGridViewBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrands.Size = new System.Drawing.Size(359, 201);
            this.dataGridViewBrands.TabIndex = 0;
            this.dataGridViewBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrands_CellClick);
            // 
            // buttonUpdateBrand
            // 
            this.buttonUpdateBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateBrand.Location = new System.Drawing.Point(467, 297);
            this.buttonUpdateBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateBrand.Name = "buttonUpdateBrand";
            this.buttonUpdateBrand.Size = new System.Drawing.Size(75, 22);
            this.buttonUpdateBrand.TabIndex = 6;
            this.buttonUpdateBrand.Text = "Actualizar";
            this.buttonUpdateBrand.UseVisualStyleBackColor = true;
            this.buttonUpdateBrand.Click += new System.EventHandler(this.buttonUpdateBrand_Click);
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteBrand.Location = new System.Drawing.Point(467, 94);
            this.buttonDeleteBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteBrand.TabIndex = 5;
            this.buttonDeleteBrand.Text = "Eliminar";
            this.buttonDeleteBrand.UseVisualStyleBackColor = true;
            this.buttonDeleteBrand.Click += new System.EventHandler(this.buttonDeleteBrand_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBrand.Location = new System.Drawing.Point(467, 27);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBrand.TabIndex = 4;
            this.buttonAddBrand.Text = "Añadir";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // txtBrandDescription
            // 
            this.txtBrandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrandDescription.Location = new System.Drawing.Point(226, 299);
            this.txtBrandDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrandDescription.MaxLength = 50;
            this.txtBrandDescription.Name = "txtBrandDescription";
            this.txtBrandDescription.Size = new System.Drawing.Size(198, 20);
            this.txtBrandDescription.TabIndex = 11;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBrandId.Enabled = false;
            this.txtBrandId.Location = new System.Drawing.Point(87, 301);
            this.txtBrandId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrandId.MaxLength = 50;
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(50, 20);
            this.txtBrandId.TabIndex = 10;
            // 
            // lblBrandDescription
            // 
            this.lblBrandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrandDescription.AutoSize = true;
            this.lblBrandDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandDescription.Location = new System.Drawing.Point(148, 301);
            this.lblBrandDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrandDescription.Name = "lblBrandDescription";
            this.lblBrandDescription.Size = new System.Drawing.Size(82, 17);
            this.lblBrandDescription.TabIndex = 9;
            this.lblBrandDescription.Text = "Descripcion";
            // 
            // lblBrandId
            // 
            this.lblBrandId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrandId.AutoSize = true;
            this.lblBrandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandId.Location = new System.Drawing.Point(63, 301);
            this.lblBrandId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrandId.Name = "lblBrandId";
            this.lblBrandId.Size = new System.Drawing.Size(21, 17);
            this.lblBrandId.TabIndex = 8;
            this.lblBrandId.Text = "ID";
            // 
            // txtBrandNew
            // 
            this.txtBrandNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrandNew.Location = new System.Drawing.Point(226, 27);
            this.txtBrandNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrandNew.MaxLength = 50;
            this.txtBrandNew.Name = "txtBrandNew";
            this.txtBrandNew.Size = new System.Drawing.Size(198, 20);
            this.txtBrandNew.TabIndex = 13;
            // 
            // lblBrandNew
            // 
            this.lblBrandNew.AutoSize = true;
            this.lblBrandNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandNew.Location = new System.Drawing.Point(63, 25);
            this.lblBrandNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrandNew.Name = "lblBrandNew";
            this.lblBrandNew.Size = new System.Drawing.Size(145, 17);
            this.lblBrandNew.TabIndex = 12;
            this.lblBrandNew.Text = "Agregar nueva Marca";
            // 
            // BrandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 362);
            this.Controls.Add(this.txtBrandNew);
            this.Controls.Add(this.lblBrandNew);
            this.Controls.Add(this.txtBrandDescription);
            this.Controls.Add(this.txtBrandId);
            this.Controls.Add(this.lblBrandDescription);
            this.Controls.Add(this.lblBrandId);
            this.Controls.Add(this.buttonUpdateBrand);
            this.Controls.Add(this.buttonDeleteBrand);
            this.Controls.Add(this.buttonAddBrand);
            this.Controls.Add(this.dataGridViewBrands);
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
        private System.Windows.Forms.TextBox txtBrandNew;
        private System.Windows.Forms.Label lblBrandNew;
    }
}