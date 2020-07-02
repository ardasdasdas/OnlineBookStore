namespace OnlineBookStore
{
    partial class UC_AdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AdminControl));
            this.pnlAdminProducts = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnladminContainer = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAdminMusicCD = new System.Windows.Forms.Button();
            this.btnAdminBook = new System.Windows.Forms.Button();
            this.btnAdminMagazine = new System.Windows.Forms.Button();
            this.pnlAdminProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdminProducts
            // 
            this.pnlAdminProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlAdminProducts.Controls.Add(this.btnCustomers);
            this.pnlAdminProducts.Controls.Add(this.lblAdmin);
            this.pnlAdminProducts.Controls.Add(this.btnAdminMusicCD);
            this.pnlAdminProducts.Controls.Add(this.btnAdminBook);
            this.pnlAdminProducts.Controls.Add(this.btnAdminMagazine);
            this.pnlAdminProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminProducts.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminProducts.Name = "pnlAdminProducts";
            this.pnlAdminProducts.Size = new System.Drawing.Size(948, 101);
            this.pnlAdminProducts.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.Location = new System.Drawing.Point(434, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(139, 24);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "ADMIN SCREEN";
            // 
            // pnladminContainer
            // 
            this.pnladminContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnladminContainer.Location = new System.Drawing.Point(0, 101);
            this.pnladminContainer.Name = "pnladminContainer";
            this.pnladminContainer.Size = new System.Drawing.Size(948, 574);
            this.pnladminContainer.TabIndex = 1;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImage = global::OnlineBookStore.Properties.Resources.user;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.Location = new System.Drawing.Point(601, 36);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(59, 59);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAdminMusicCD
            // 
            this.btnAdminMusicCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminMusicCD.BackgroundImage")));
            this.btnAdminMusicCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminMusicCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMusicCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminMusicCD.Location = new System.Drawing.Point(503, 36);
            this.btnAdminMusicCD.Name = "btnAdminMusicCD";
            this.btnAdminMusicCD.Size = new System.Drawing.Size(59, 59);
            this.btnAdminMusicCD.TabIndex = 3;
            this.btnAdminMusicCD.UseVisualStyleBackColor = true;
            this.btnAdminMusicCD.Click += new System.EventHandler(this.btnAdminMusicCD_Click);
            // 
            // btnAdminBook
            // 
            this.btnAdminBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminBook.BackgroundImage")));
            this.btnAdminBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminBook.Location = new System.Drawing.Point(307, 36);
            this.btnAdminBook.Name = "btnAdminBook";
            this.btnAdminBook.Size = new System.Drawing.Size(59, 59);
            this.btnAdminBook.TabIndex = 1;
            this.btnAdminBook.UseVisualStyleBackColor = true;
            this.btnAdminBook.Click += new System.EventHandler(this.btnAdminBook_Click);
            // 
            // btnAdminMagazine
            // 
            this.btnAdminMagazine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminMagazine.BackgroundImage")));
            this.btnAdminMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminMagazine.Location = new System.Drawing.Point(405, 36);
            this.btnAdminMagazine.Name = "btnAdminMagazine";
            this.btnAdminMagazine.Size = new System.Drawing.Size(59, 59);
            this.btnAdminMagazine.TabIndex = 2;
            this.btnAdminMagazine.UseVisualStyleBackColor = true;
            this.btnAdminMagazine.Click += new System.EventHandler(this.btnAdminMagazine_Click);
            // 
            // UC_AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnladminContainer);
            this.Controls.Add(this.pnlAdminProducts);
            this.Name = "UC_AdminControl";
            this.Size = new System.Drawing.Size(948, 675);
            this.pnlAdminProducts.ResumeLayout(false);
            this.pnlAdminProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminProducts;
        private System.Windows.Forms.Button btnAdminMusicCD;
        private System.Windows.Forms.Button btnAdminBook;
        private System.Windows.Forms.Button btnAdminMagazine;
        private System.Windows.Forms.Panel pnladminContainer;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnCustomers;
    }
}
