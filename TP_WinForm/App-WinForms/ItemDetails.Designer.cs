namespace App_WinForms
{
    partial class ItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetails));
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelImages = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApplyItem = new System.Windows.Forms.Button();
            this.buttonPreviousImage = new System.Windows.Forms.Button();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonNextImage = new System.Windows.Forms.Button();
            this.textBoxImageUrl = new System.Windows.Forms.TextBox();
            this.buttonApplyUrl = new System.Windows.Forms.Button();
            this.buttonDeleteUrl = new System.Windows.Forms.Button();
            this.buttonEditUrl = new System.Windows.Forms.Button();
            this.buttonAddUrl = new System.Windows.Forms.Button();
            this.pictureBoxImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(40, 30);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(19, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Id:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 110);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nombre:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(340, 150);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(66, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Descripción:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(40, 70);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(43, 13);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Código:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(340, 30);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(40, 13);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Marca:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(340, 70);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(57, 13);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Categoría:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(340, 110);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Precio:";
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.Location = new System.Drawing.Point(40, 330);
            this.labelImages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(23, 13);
            this.labelImages.TabIndex = 7;
            this.labelImages.Text = "Url:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(100, 70);
            this.textBoxCode.MaxLength = 50;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(200, 20);
            this.textBoxCode.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxID.Location = new System.Drawing.Point(100, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(55, 20);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 110);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(340, 170);
            this.textBoxDescription.MaxLength = 50;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(280, 120);
            this.textBoxDescription.TabIndex = 12;
            this.textBoxDescription.Text = "";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(420, 110);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice.TabIndex = 15;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(545, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 40);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApplyItem
            // 
            this.buttonApplyItem.Location = new System.Drawing.Point(433, 310);
            this.buttonApplyItem.Name = "buttonApplyItem";
            this.buttonApplyItem.Size = new System.Drawing.Size(95, 40);
            this.buttonApplyItem.TabIndex = 19;
            this.buttonApplyItem.Text = "Aplicar Cambios";
            this.buttonApplyItem.UseVisualStyleBackColor = true;
            this.buttonApplyItem.Visible = false;
            this.buttonApplyItem.Click += new System.EventHandler(this.buttonApplyItem_Click);
            // 
            // buttonPreviousImage
            // 
            this.buttonPreviousImage.Location = new System.Drawing.Point(273, 178);
            this.buttonPreviousImage.Name = "buttonPreviousImage";
            this.buttonPreviousImage.Size = new System.Drawing.Size(27, 27);
            this.buttonPreviousImage.TabIndex = 21;
            this.buttonPreviousImage.Text = "←";
            this.buttonPreviousImage.UseVisualStyleBackColor = true;
            this.buttonPreviousImage.Click += new System.EventHandler(this.buttonPreviousImage_Click);
            // 
            // cbBrands
            // 
            this.cbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(420, 30);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(200, 21);
            this.cbBrands.TabIndex = 22;
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(420, 70);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(200, 21);
            this.cbCategories.TabIndex = 23;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(453, 310);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 40);
            this.buttonAddItem.TabIndex = 24;
            this.buttonAddItem.Text = "Añadir";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Visible = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonNextImage
            // 
            this.buttonNextImage.Location = new System.Drawing.Point(273, 145);
            this.buttonNextImage.Name = "buttonNextImage";
            this.buttonNextImage.Size = new System.Drawing.Size(27, 27);
            this.buttonNextImage.TabIndex = 20;
            this.buttonNextImage.Text = "→";
            this.buttonNextImage.UseVisualStyleBackColor = true;
            this.buttonNextImage.Click += new System.EventHandler(this.buttonNextImage_Click);
            // 
            // textBoxImageUrl
            // 
            this.textBoxImageUrl.Location = new System.Drawing.Point(80, 330);
            this.textBoxImageUrl.MaxLength = 50;
            this.textBoxImageUrl.Name = "textBoxImageUrl";
            this.textBoxImageUrl.ReadOnly = true;
            this.textBoxImageUrl.Size = new System.Drawing.Size(180, 20);
            this.textBoxImageUrl.TabIndex = 28;
            // 
            // buttonApplyUrl
            // 
            this.buttonApplyUrl.Image = global::App_WinForms.Properties.Resources.check;
            this.buttonApplyUrl.Location = new System.Drawing.Point(273, 326);
            this.buttonApplyUrl.Name = "buttonApplyUrl";
            this.buttonApplyUrl.Size = new System.Drawing.Size(27, 27);
            this.buttonApplyUrl.TabIndex = 29;
            this.buttonApplyUrl.UseVisualStyleBackColor = true;
            this.buttonApplyUrl.Click += new System.EventHandler(this.buttonApplyUrl_Click);
            // 
            // buttonDeleteUrl
            // 
            this.buttonDeleteUrl.Image = global::App_WinForms.Properties.Resources.delete;
            this.buttonDeleteUrl.Location = new System.Drawing.Point(273, 275);
            this.buttonDeleteUrl.Name = "buttonDeleteUrl";
            this.buttonDeleteUrl.Size = new System.Drawing.Size(27, 27);
            this.buttonDeleteUrl.TabIndex = 27;
            this.buttonDeleteUrl.UseVisualStyleBackColor = true;
            this.buttonDeleteUrl.Click += new System.EventHandler(this.buttonDeleteUrl_Click);
            // 
            // buttonEditUrl
            // 
            this.buttonEditUrl.Image = global::App_WinForms.Properties.Resources.edit;
            this.buttonEditUrl.Location = new System.Drawing.Point(273, 242);
            this.buttonEditUrl.Name = "buttonEditUrl";
            this.buttonEditUrl.Size = new System.Drawing.Size(27, 27);
            this.buttonEditUrl.TabIndex = 26;
            this.buttonEditUrl.UseVisualStyleBackColor = true;
            this.buttonEditUrl.Click += new System.EventHandler(this.buttonEditUrl_Click);
            // 
            // buttonAddUrl
            // 
            this.buttonAddUrl.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddUrl.Image")));
            this.buttonAddUrl.Location = new System.Drawing.Point(273, 211);
            this.buttonAddUrl.Name = "buttonAddUrl";
            this.buttonAddUrl.Size = new System.Drawing.Size(27, 27);
            this.buttonAddUrl.TabIndex = 25;
            this.buttonAddUrl.UseVisualStyleBackColor = true;
            this.buttonAddUrl.Click += new System.EventHandler(this.buttonAddUrl_Click);
            // 
            // pictureBoxImages
            // 
            this.pictureBoxImages.Image = global::App_WinForms.Properties.Resources.ErrorImage;
            this.pictureBoxImages.Location = new System.Drawing.Point(40, 150);
            this.pictureBoxImages.Name = "pictureBoxImages";
            this.pictureBoxImages.Size = new System.Drawing.Size(220, 160);
            this.pictureBoxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImages.TabIndex = 16;
            this.pictureBoxImages.TabStop = false;
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.buttonApplyUrl);
            this.Controls.Add(this.textBoxImageUrl);
            this.Controls.Add(this.buttonDeleteUrl);
            this.Controls.Add(this.buttonEditUrl);
            this.Controls.Add(this.buttonAddUrl);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.buttonPreviousImage);
            this.Controls.Add(this.buttonNextImage);
            this.Controls.Add(this.buttonApplyItem);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxImages);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelImages);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "ItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemDetails_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBoxImages;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApplyItem;
        private System.Windows.Forms.Button buttonNextImage;
        private System.Windows.Forms.Button buttonPreviousImage;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonAddUrl;
        private System.Windows.Forms.Button buttonEditUrl;
        private System.Windows.Forms.Button buttonDeleteUrl;
        private System.Windows.Forms.TextBox textBoxImageUrl;
        private System.Windows.Forms.Button buttonApplyUrl;
    }
}