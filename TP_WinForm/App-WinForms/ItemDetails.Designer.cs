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
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBoxImages = new System.Windows.Forms.PictureBox();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApplyItem = new System.Windows.Forms.Button();
            this.buttonNextImage = new System.Windows.Forms.Button();
            this.buttonPreviousImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(30, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nombre:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 150);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(66, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Descripción:";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(30, 70);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(43, 13);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Código:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(290, 30);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(40, 13);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Marca:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(290, 70);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(57, 13);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Categoría:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(290, 110);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Precio:";
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.Location = new System.Drawing.Point(290, 150);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(56, 13);
            this.labelImages.TabIndex = 7;
            this.labelImages.Text = "Imágenes:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(100, 70);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(173, 20);
            this.textBoxCode.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(100, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(55, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(30, 190);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(243, 100);
            this.textBoxDescription.TabIndex = 12;
            this.textBoxDescription.Text = "";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(353, 30);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(173, 20);
            this.textBoxBrand.TabIndex = 13;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(353, 70);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(173, 20);
            this.textBoxCategory.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(353, 110);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(173, 20);
            this.textBoxPrice.TabIndex = 15;
            // 
            // pictureBoxImages
            // 
            this.pictureBoxImages.Location = new System.Drawing.Point(293, 190);
            this.pictureBoxImages.Name = "pictureBoxImages";
            this.pictureBoxImages.Size = new System.Drawing.Size(233, 100);
            this.pictureBoxImages.TabIndex = 16;
            this.pictureBoxImages.TabStop = false;
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(370, 305);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveItem.TabIndex = 17;
            this.buttonSaveItem.Text = "Guardar";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(451, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApplyItem
            // 
            this.buttonApplyItem.Location = new System.Drawing.Point(289, 305);
            this.buttonApplyItem.Name = "buttonApplyItem";
            this.buttonApplyItem.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyItem.TabIndex = 19;
            this.buttonApplyItem.Text = "Aplicar";
            this.buttonApplyItem.UseVisualStyleBackColor = true;
            // 
            // buttonNextImage
            // 
            this.buttonNextImage.Location = new System.Drawing.Point(532, 190);
            this.buttonNextImage.Name = "buttonNextImage";
            this.buttonNextImage.Size = new System.Drawing.Size(27, 23);
            this.buttonNextImage.TabIndex = 20;
            this.buttonNextImage.Text = "→";
            this.buttonNextImage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousImage
            // 
            this.buttonPreviousImage.Location = new System.Drawing.Point(532, 219);
            this.buttonPreviousImage.Name = "buttonPreviousImage";
            this.buttonPreviousImage.Size = new System.Drawing.Size(27, 23);
            this.buttonPreviousImage.TabIndex = 21;
            this.buttonPreviousImage.Text = "←";
            this.buttonPreviousImage.UseVisualStyleBackColor = true;
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 362);
            this.Controls.Add(this.buttonPreviousImage);
            this.Controls.Add(this.buttonNextImage);
            this.Controls.Add(this.buttonApplyItem);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.pictureBoxImages);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxBrand);
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
            this.Text = "Detalles del producto";
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
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBoxImages;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApplyItem;
        private System.Windows.Forms.Button buttonNextImage;
        private System.Windows.Forms.Button buttonPreviousImage;
    }
}