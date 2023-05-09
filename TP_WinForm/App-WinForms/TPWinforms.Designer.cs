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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.buttonBrandWindow = new System.Windows.Forms.Button();
            this.buttonCategoryWindow = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.numPriceMin = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.numPriceMax = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddItem = new FontAwesome.Sharp.IconButton();
            this.buttonDeleteItem = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonViewDetails = new FontAwesome.Sharp.IconButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.cbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.ForeColor = System.Drawing.Color.LightGray;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(836, 41);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(169, 28);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.FilterEvent);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(215, 133);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(866, 336);
            this.dgvItems.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombre.Location = new System.Drawing.Point(381, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // buttonBrandWindow
            // 
            this.buttonBrandWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrandWindow.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrandWindow.Location = new System.Drawing.Point(52, 498);
            this.buttonBrandWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrandWindow.Name = "buttonBrandWindow";
            this.buttonBrandWindow.Size = new System.Drawing.Size(152, 31);
            this.buttonBrandWindow.TabIndex = 6;
            this.buttonBrandWindow.Text = "Gestionar Marcas";
            this.buttonBrandWindow.UseVisualStyleBackColor = true;
            this.buttonBrandWindow.Click += new System.EventHandler(this.buttonBrandWindow_Click);
            // 
            // buttonCategoryWindow
            // 
            this.buttonCategoryWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCategoryWindow.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategoryWindow.Location = new System.Drawing.Point(244, 498);
            this.buttonCategoryWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCategoryWindow.Name = "buttonCategoryWindow";
            this.buttonCategoryWindow.Size = new System.Drawing.Size(161, 31);
            this.buttonCategoryWindow.TabIndex = 7;
            this.buttonCategoryWindow.Text = "Gestionar Categorías";
            this.buttonCategoryWindow.UseVisualStyleBackColor = true;
            this.buttonCategoryWindow.Click += new System.EventHandler(this.buttonCategoryWindow_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.LightGray;
            this.lblCategory.Location = new System.Drawing.Point(621, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 22);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Categoria";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.LightGray;
            this.lblBrand.Location = new System.Drawing.Point(832, 11);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 22);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Marca";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombre.Location = new System.Drawing.Point(377, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.LightGray;
            this.lblCode.Location = new System.Drawing.Point(211, 11);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(68, 22);
            this.lblCode.TabIndex = 13;
            this.lblCode.Text = "Codigo";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(211, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 22);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Descripcion";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.LightGray;
            this.txtCode.Location = new System.Drawing.Point(215, 41);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 26);
            this.txtCode.TabIndex = 15;
            this.txtCode.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.LightGray;
            this.txtDescription.Location = new System.Drawing.Point(215, 92);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 26);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // numPriceMin
            // 
            this.numPriceMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.numPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceMin.ForeColor = System.Drawing.Color.LightGray;
            this.numPriceMin.Location = new System.Drawing.Point(697, 93);
            this.numPriceMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPriceMin.Name = "numPriceMin";
            this.numPriceMin.Size = new System.Drawing.Size(120, 26);
            this.numPriceMin.TabIndex = 17;
            this.numPriceMin.ValueChanged += new System.EventHandler(this.FilterEvent);
            this.numPriceMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPriceMin_KeyUp);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.LightGray;
            this.lblPrice.Location = new System.Drawing.Point(549, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Precio";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.LightGray;
            this.lblMin.Location = new System.Drawing.Point(639, 95);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(41, 22);
            this.lblMin.TabIndex = 19;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.LightGray;
            this.lblMax.Location = new System.Drawing.Point(845, 95);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(44, 22);
            this.lblMax.TabIndex = 20;
            this.lblMax.Text = "Max";
            // 
            // numPriceMax
            // 
            this.numPriceMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.numPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceMax.ForeColor = System.Drawing.Color.LightGray;
            this.numPriceMax.Location = new System.Drawing.Point(898, 93);
            this.numPriceMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPriceMax.Name = "numPriceMax";
            this.numPriceMax.Size = new System.Drawing.Size(120, 26);
            this.numPriceMax.TabIndex = 21;
            this.numPriceMax.ValueChanged += new System.EventHandler(this.FilterEvent);
            this.numPriceMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPriceMax_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.buttonAddItem);
            this.panel1.Controls.Add(this.buttonDeleteItem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonViewDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 482);
            this.panel1.TabIndex = 22;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.FlatAppearance.BorderSize = 0;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAddItem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.buttonAddItem.IconColor = System.Drawing.Color.LightGray;
            this.buttonAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddItem.IconSize = 55;
            this.buttonAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddItem.Location = new System.Drawing.Point(3, 218);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Padding = new System.Windows.Forms.Padding(6);
            this.buttonAddItem.Size = new System.Drawing.Size(200, 102);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Agregar";
            this.buttonAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click_2);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.FlatAppearance.BorderSize = 0;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteItem.ForeColor = System.Drawing.Color.LightGray;
            this.buttonDeleteItem.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttonDeleteItem.IconColor = System.Drawing.Color.LightGray;
            this.buttonDeleteItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDeleteItem.IconSize = 55;
            this.buttonDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteItem.Location = new System.Drawing.Point(0, 339);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Padding = new System.Windows.Forms.Padding(6);
            this.buttonDeleteItem.Size = new System.Drawing.Size(200, 102);
            this.buttonDeleteItem.TabIndex = 1;
            this.buttonDeleteItem.Text = "Eliminar";
            this.buttonDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click_2);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.FlatAppearance.BorderSize = 0;
            this.buttonViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewDetails.ForeColor = System.Drawing.Color.LightGray;
            this.buttonViewDetails.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.buttonViewDetails.IconColor = System.Drawing.Color.LightGray;
            this.buttonViewDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonViewDetails.IconSize = 55;
            this.buttonViewDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewDetails.Location = new System.Drawing.Point(0, 106);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Padding = new System.Windows.Forms.Padding(6);
            this.buttonViewDetails.Size = new System.Drawing.Size(200, 95);
            this.buttonViewDetails.TabIndex = 0;
            this.buttonViewDetails.Text = "Ver detalles";
            this.buttonViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.LightGray;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(625, 41);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(179, 28);
            this.cbCategory.TabIndex = 23;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.FilterEvent);
            // 
            // TPWinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numPriceMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPriceMin);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.buttonCategoryWindow);
            this.Controls.Add(this.buttonBrandWindow);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.cbBrand);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1181, 529);
            this.Name = "TPWinforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPWinforms";
            this.Activated += new System.EventHandler(this.TPWinforms_Activated);
            this.Load += new System.EventHandler(this.TPWinforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button buttonBrandWindow;
        private System.Windows.Forms.Button buttonCategoryWindow;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numPriceMin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numPriceMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private FontAwesome.Sharp.IconButton buttonViewDetails;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonAddItem;
        private FontAwesome.Sharp.IconButton buttonDeleteItem;
    }
}

