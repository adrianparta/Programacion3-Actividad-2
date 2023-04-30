namespace App_WinForms
{
    partial class TPWinforms
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFilter1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter2 = new System.Windows.Forms.ComboBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewDetails = new System.Windows.Forms.Button();
            this.buttonBrandWindow = new System.Windows.Forms.Button();
            this.buttonCategoryWindow = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilter1
            // 
            this.comboBoxFilter1.FormattingEnabled = true;
            this.comboBoxFilter1.Location = new System.Drawing.Point(354, 31);
            this.comboBoxFilter1.Name = "comboBoxFilter1";
            this.comboBoxFilter1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter1.TabIndex = 0;
            // 
            // comboBoxFilter2
            // 
            this.comboBoxFilter2.FormattingEnabled = true;
            this.comboBoxFilter2.Location = new System.Drawing.Point(501, 32);
            this.comboBoxFilter2.Name = "comboBoxFilter2";
            this.comboBoxFilter2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter2.TabIndex = 1;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(39, 74);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(693, 269);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Location = new System.Drawing.Point(39, 32);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(277, 20);
            this.textBoxSearchBar.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(657, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.Location = new System.Drawing.Point(766, 74);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(102, 25);
            this.buttonViewDetails.TabIndex = 5;
            this.buttonViewDetails.Text = "Ver Detalles";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.buttonViewDetails_Click);
            // 
            // buttonBrandWindow
            // 
            this.buttonBrandWindow.Location = new System.Drawing.Point(39, 367);
            this.buttonBrandWindow.Name = "buttonBrandWindow";
            this.buttonBrandWindow.Size = new System.Drawing.Size(114, 25);
            this.buttonBrandWindow.TabIndex = 6;
            this.buttonBrandWindow.Text = "Gestionar Marcas";
            this.buttonBrandWindow.UseVisualStyleBackColor = true;
            this.buttonBrandWindow.Click += new System.EventHandler(this.buttonBrandWindow_Click);
            // 
            // buttonCategoryWindow
            // 
            this.buttonCategoryWindow.Location = new System.Drawing.Point(181, 367);
            this.buttonCategoryWindow.Name = "buttonCategoryWindow";
            this.buttonCategoryWindow.Size = new System.Drawing.Size(121, 25);
            this.buttonCategoryWindow.TabIndex = 7;
            this.buttonCategoryWindow.Text = "Gestionar Categorías";
            this.buttonCategoryWindow.UseVisualStyleBackColor = true;
            this.buttonCategoryWindow.Click += new System.EventHandler(this.buttonCategoryWindow_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(766, 133);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(102, 25);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Eliminar";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(766, 193);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(102, 25);
            this.buttonAddItem.TabIndex = 9;
            this.buttonAddItem.Text = "Añadir Producto";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // TPWinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 426);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonCategoryWindow);
            this.Controls.Add(this.buttonBrandWindow);
            this.Controls.Add(this.buttonViewDetails);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.comboBoxFilter2);
            this.Controls.Add(this.comboBoxFilter1);
            this.Name = "TPWinforms";
            this.Text = "TPWinforms";
            this.Load += new System.EventHandler(this.TPWinforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilter1;
        private System.Windows.Forms.ComboBox comboBoxFilter2;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewDetails;
        private System.Windows.Forms.Button buttonBrandWindow;
        private System.Windows.Forms.Button buttonCategoryWindow;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonAddItem;
    }
}

