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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewDetails = new System.Windows.Forms.Button();
            this.buttonBrandWindow = new System.Windows.Forms.Button();
            this.buttonCategoryWindow = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(501, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(657, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.Location = new System.Drawing.Point(766, 74);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(102, 25);
            this.buttonViewDetails.TabIndex = 5;
            this.buttonViewDetails.Text = "Ver Detalles";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            // 
            // buttonBrandWindow
            // 
            this.buttonBrandWindow.Location = new System.Drawing.Point(39, 367);
            this.buttonBrandWindow.Name = "buttonBrandWindow";
            this.buttonBrandWindow.Size = new System.Drawing.Size(114, 25);
            this.buttonBrandWindow.TabIndex = 6;
            this.buttonBrandWindow.Text = "Gestionar Marcas";
            this.buttonBrandWindow.UseVisualStyleBackColor = true;
            // 
            // buttonCategoryWindow
            // 
            this.buttonCategoryWindow.Location = new System.Drawing.Point(181, 367);
            this.buttonCategoryWindow.Name = "buttonCategoryWindow";
            this.buttonCategoryWindow.Size = new System.Drawing.Size(121, 25);
            this.buttonCategoryWindow.TabIndex = 7;
            this.buttonCategoryWindow.Text = "Gestionar Categorías";
            this.buttonCategoryWindow.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "TPWinforms";
            this.Text = "TPWinforms";
            this.Load += new System.EventHandler(this.TPWinforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewDetails;
        private System.Windows.Forms.Button buttonBrandWindow;
        private System.Windows.Forms.Button buttonCategoryWindow;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonAddItem;
    }
}

