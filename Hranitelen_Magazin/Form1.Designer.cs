namespace Hranitelen_Magazin
{
    partial class HranitelenMagazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HranitelenMagazin));
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnFIND = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(29, 216);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(94, 50);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(150, 216);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(88, 50);
            this.btnUPDATE.TabIndex = 1;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(31, 280);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(92, 53);
            this.btnDELETE.TabIndex = 2;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnFIND
            // 
            this.btnFIND.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIND.Location = new System.Drawing.Point(531, 298);
            this.btnFIND.Name = "btnFIND";
            this.btnFIND.Size = new System.Drawing.Size(128, 63);
            this.btnFIND.TabIndex = 3;
            this.btnFIND.Text = "FIND";
            this.btnFIND.UseVisualStyleBackColor = true;
            this.btnFIND.Click += new System.EventHandler(this.btnFIND_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblID.Location = new System.Drawing.Point(553, 254);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(172, 33);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Find by ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(665, 298);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 63);
            this.txtID.TabIndex = 6;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(133, 31);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(129, 26);
            this.txtBrand.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(135, 132);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(127, 31);
            this.txtDescription.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(196, 64);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(66, 24);
            this.txtPrice.TabIndex = 9;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblBrand.Location = new System.Drawing.Point(5, 36);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(77, 23);
            this.lblBrand.TabIndex = 10;
            this.lblBrand.Text = "Brand:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblDescription.Location = new System.Drawing.Point(4, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 23);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblPrice.Location = new System.Drawing.Point(5, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblExpirationDate.Location = new System.Drawing.Point(4, 100);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(168, 23);
            this.lblExpirationDate.TabIndex = 13;
            this.lblExpirationDate.Text = "ExpirationDate:";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationDate.Location = new System.Drawing.Point(181, 94);
            this.txtExpirationDate.Multiline = true;
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(81, 32);
            this.txtExpirationDate.TabIndex = 14;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblProductType.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblProductType.Location = new System.Drawing.Point(5, 172);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(134, 23);
            this.lblProductType.TabIndex = 15;
            this.lblProductType.Text = "ProductType";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(268, 26);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(845, 225);
            this.listBox.TabIndex = 17;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(141, 172);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(121, 27);
            this.cmbProductType.TabIndex = 18;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(150, 280);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(88, 53);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // HranitelenMagazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 373);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnFIND);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HranitelenMagazin";
            this.Text = "HranitelenMagazin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnFIND;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button btnClearAll;
    }
}

