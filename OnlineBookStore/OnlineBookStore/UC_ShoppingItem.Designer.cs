namespace OnlineBookStore
{
    partial class UC_ShoppingItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShoppingItem = new System.Windows.Forms.Panel();
            this.picCoverPage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblProductQuantitiy = new System.Windows.Forms.Label();
            this.lblHeaderTotalPrice = new System.Windows.Forms.Label();
            this.lblHeaderQuantity = new System.Windows.Forms.Label();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.lblHeaderUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnSubtractProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlShoppingItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShoppingItem
            // 
            this.pnlShoppingItem.BackColor = System.Drawing.Color.Teal;
            this.pnlShoppingItem.Controls.Add(this.picCoverPage);
            this.pnlShoppingItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShoppingItem.Location = new System.Drawing.Point(0, 0);
            this.pnlShoppingItem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShoppingItem.Name = "pnlShoppingItem";
            this.pnlShoppingItem.Size = new System.Drawing.Size(152, 119);
            this.pnlShoppingItem.TabIndex = 39;
            // 
            // picCoverPage
            // 
            this.picCoverPage.Location = new System.Drawing.Point(16, 23);
            this.picCoverPage.Margin = new System.Windows.Forms.Padding(4);
            this.picCoverPage.Name = "picCoverPage";
            this.picCoverPage.Size = new System.Drawing.Size(116, 107);
            this.picCoverPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoverPage.TabIndex = 0;
            this.picCoverPage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(157, 89);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 46;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(776, 91);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(26, 18);
            this.lblTotalPrice.TabIndex = 45;
            this.lblTotalPrice.Text = "$0";
            // 
            // lblProductQuantitiy
            // 
            this.lblProductQuantitiy.AutoSize = true;
            this.lblProductQuantitiy.BackColor = System.Drawing.Color.Transparent;
            this.lblProductQuantitiy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductQuantitiy.ForeColor = System.Drawing.Color.Black;
            this.lblProductQuantitiy.Location = new System.Drawing.Point(521, 87);
            this.lblProductQuantitiy.Name = "lblProductQuantitiy";
            this.lblProductQuantitiy.Size = new System.Drawing.Size(19, 21);
            this.lblProductQuantitiy.TabIndex = 44;
            this.lblProductQuantitiy.Text = "0";
            // 
            // lblHeaderTotalPrice
            // 
            this.lblHeaderTotalPrice.AutoSize = true;
            this.lblHeaderTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderTotalPrice.Location = new System.Drawing.Point(748, 23);
            this.lblHeaderTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTotalPrice.Name = "lblHeaderTotalPrice";
            this.lblHeaderTotalPrice.Size = new System.Drawing.Size(101, 20);
            this.lblHeaderTotalPrice.TabIndex = 41;
            this.lblHeaderTotalPrice.Text = "Total Price";
            // 
            // lblHeaderQuantity
            // 
            this.lblHeaderQuantity.AutoSize = true;
            this.lblHeaderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderQuantity.Location = new System.Drawing.Point(512, 23);
            this.lblHeaderQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderQuantity.Name = "lblHeaderQuantity";
            this.lblHeaderQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblHeaderQuantity.TabIndex = 40;
            this.lblHeaderQuantity.Text = "Quantity";
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderName.Location = new System.Drawing.Point(188, 23);
            this.lblHeaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(57, 20);
            this.lblHeaderName.TabIndex = 38;
            this.lblHeaderName.Text = "Name";
            // 
            // lblHeaderUnitPrice
            // 
            this.lblHeaderUnitPrice.AutoSize = true;
            this.lblHeaderUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderUnitPrice.Location = new System.Drawing.Point(625, 23);
            this.lblHeaderUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderUnitPrice.Name = "lblHeaderUnitPrice";
            this.lblHeaderUnitPrice.Size = new System.Drawing.Size(93, 20);
            this.lblHeaderUnitPrice.TabIndex = 47;
            this.lblHeaderUnitPrice.Text = "Unit Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitPrice.Location = new System.Drawing.Point(648, 90);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(26, 18);
            this.lblUnitPrice.TabIndex = 48;
            this.lblUnitPrice.Text = "$0";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Image = global::OnlineBookStore.Properties.Resources.shopping_cart;
            this.btnCancelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelItem.Location = new System.Drawing.Point(860, 69);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(148, 57);
            this.btnCancelItem.TabIndex = 49;
            this.btnCancelItem.Text = "Cancel Item";
            this.btnCancelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnSubtractProduct
            // 
            this.btnSubtractProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSubtractProduct.BackgroundImage = global::OnlineBookStore.Properties.Resources.subtraction;
            this.btnSubtractProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubtractProduct.FlatAppearance.BorderSize = 0;
            this.btnSubtractProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtractProduct.Location = new System.Drawing.Point(547, 105);
            this.btnSubtractProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtractProduct.Name = "btnSubtractProduct";
            this.btnSubtractProduct.Size = new System.Drawing.Size(23, 23);
            this.btnSubtractProduct.TabIndex = 43;
            this.btnSubtractProduct.UseVisualStyleBackColor = false;
            this.btnSubtractProduct.Click += new System.EventHandler(this.btnSubtractProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackgroundImage = global::OnlineBookStore.Properties.Resources.addition;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(547, 58);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 42;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // UC_ShoppingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblHeaderUnitPrice);
            this.Controls.Add(this.pnlShoppingItem);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblProductQuantitiy);
            this.Controls.Add(this.btnSubtractProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblHeaderTotalPrice);
            this.Controls.Add(this.lblHeaderQuantity);
            this.Controls.Add(this.lblHeaderName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ShoppingItem";
            this.Size = new System.Drawing.Size(893, 119);
            this.pnlShoppingItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShoppingItem;
        private System.Windows.Forms.PictureBox picCoverPage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblProductQuantitiy;
        private System.Windows.Forms.Button btnSubtractProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblHeaderTotalPrice;
        private System.Windows.Forms.Label lblHeaderQuantity;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblHeaderUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnCancelItem;
    }
}
