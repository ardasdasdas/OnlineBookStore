namespace OnlineBookStore
{
    partial class UC_ShoppingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ShoppingList));
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTOTALPAYMENT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutShoppingList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformations
            // 
            this.pnlInformations.Controls.Add(this.label1);
            this.pnlInformations.Controls.Add(this.lblTOTALPAYMENT);
            this.pnlInformations.Controls.Add(this.pictureBox1);
            this.pnlInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformations.Location = new System.Drawing.Point(0, 0);
            this.pnlInformations.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(1020, 87);
            this.pnlInformations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(723, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Payment :";
            // 
            // lblTOTALPAYMENT
            // 
            this.lblTOTALPAYMENT.AutoSize = true;
            this.lblTOTALPAYMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTOTALPAYMENT.Location = new System.Drawing.Point(881, 31);
            this.lblTOTALPAYMENT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOTALPAYMENT.Name = "lblTOTALPAYMENT";
            this.lblTOTALPAYMENT.Size = new System.Drawing.Size(0, 25);
            this.lblTOTALPAYMENT.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineBookStore.Properties.Resources.button_basket_books_magazines_book_store_512;
            this.pictureBox1.Location = new System.Drawing.Point(599, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDown
            // 
            this.pnlDown.Controls.Add(this.btnCheckout);
            this.pnlDown.Controls.Add(this.btnCancel);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 625);
            this.pnlDown.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(1020, 86);
            this.pnlDown.TabIndex = 2;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(768, 21);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(171, 49);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "CheckOut";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Image = global::OnlineBookStore.Properties.Resources.basket;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(28, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 49);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutShoppingList
            // 
            this.flowLayoutShoppingList.AutoScroll = true;
            this.flowLayoutShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutShoppingList.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutShoppingList.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutShoppingList.Name = "flowLayoutShoppingList";
            this.flowLayoutShoppingList.Size = new System.Drawing.Size(1020, 538);
            this.flowLayoutShoppingList.TabIndex = 3;
            // 
            // UC_ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutShoppingList);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlInformations);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ShoppingList";
            this.Size = new System.Drawing.Size(1020, 711);
            this.pnlInformations.ResumeLayout(false);
            this.pnlInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInformations;
        private System.Windows.Forms.Panel pnlDown;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutShoppingList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTOTALPAYMENT;
        private System.Windows.Forms.Button btnCheckout;
    }
}
