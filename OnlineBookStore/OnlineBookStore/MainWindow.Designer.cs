namespace OnlineBookStore
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMyCart = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnMusicCDs = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlBookStore = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.pnlDream = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerWelcomeString = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSelectedButton = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMenu.Controls.Add(this.pnlSelectedButton);
            this.pnlMenu.Controls.Add(this.btnMyCart);
            this.pnlMenu.Controls.Add(this.btnMyOrders);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnMagazine);
            this.pnlMenu.Controls.Add(this.btnMusicCDs);
            this.pnlMenu.Controls.Add(this.btnBooks);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 49);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(188, 674);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnMyCart
            // 
            this.btnMyCart.BackColor = System.Drawing.Color.Transparent;
            this.btnMyCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCart.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMyCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMyCart.Image = global::OnlineBookStore.Properties.Resources.market;
            this.btnMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyCart.Location = new System.Drawing.Point(0, 299);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(188, 64);
            this.btnMyCart.TabIndex = 8;
            this.btnMyCart.Text = " My Cart";
            this.btnMyCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCart.UseVisualStyleBackColor = false;
            this.btnMyCart.Click += new System.EventHandler(this.btnMyCart_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnMyOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMyOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMyOrders.Image = global::OnlineBookStore.Properties.Resources.delivery_service;
            this.btnMyOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 239);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(188, 64);
            this.btnMyOrders.TabIndex = 7;
            this.btnMyOrders.Text = " My Orders";
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Location = new System.Drawing.Point(3, 622);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(74, 62);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.Color.Transparent;
            this.btnMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMagazine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMagazine.Image = global::OnlineBookStore.Properties.Resources.magazine;
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMagazine.Location = new System.Drawing.Point(0, 179);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(188, 64);
            this.btnMagazine.TabIndex = 3;
            this.btnMagazine.Text = " Magazines";
            this.btnMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnMusicCDs
            // 
            this.btnMusicCDs.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicCDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusicCDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDs.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMusicCDs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMusicCDs.Image = global::OnlineBookStore.Properties.Resources.music__3_;
            this.btnMusicCDs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusicCDs.Location = new System.Drawing.Point(0, 120);
            this.btnMusicCDs.Name = "btnMusicCDs";
            this.btnMusicCDs.Size = new System.Drawing.Size(188, 64);
            this.btnMusicCDs.TabIndex = 2;
            this.btnMusicCDs.Text = " Music CDs";
            this.btnMusicCDs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicCDs.UseVisualStyleBackColor = false;
            this.btnMusicCDs.Click += new System.EventHandler(this.btnMusicCDs_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBooks.Image = global::OnlineBookStore.Properties.Resources.books;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.Location = new System.Drawing.Point(0, 60);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(188, 64);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = " Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDashboard.Image = global::OnlineBookStore.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 64);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.Location = new System.Drawing.Point(0, 360);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(188, 64);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = " Settings";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.LightBlue;
            this.pnlStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStatus.Controls.Add(this.picIcon);
            this.pnlStatus.Controls.Add(this.pnlBookStore);
            this.pnlStatus.Controls.Add(this.lblWelcome);
            this.pnlStatus.Controls.Add(this.pnlTime);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1040, 49);
            this.pnlStatus.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Image = global::OnlineBookStore.Properties.Resources.dream_book;
            this.picIcon.Location = new System.Drawing.Point(0, -1);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(47, 51);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // pnlBookStore
            // 
            this.pnlBookStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBookStore.BackgroundImage")));
            this.pnlBookStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBookStore.Location = new System.Drawing.Point(53, 25);
            this.pnlBookStore.Name = "pnlBookStore";
            this.pnlBookStore.Size = new System.Drawing.Size(135, 21);
            this.pnlBookStore.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Tomato;
            this.lblWelcome.Location = new System.Drawing.Point(446, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(91, 25);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome";
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.Teal;
            this.pnlTime.Controls.Add(this.pnlDream);
            this.pnlTime.Controls.Add(this.btnExit);
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Controls.Add(this.lblDate);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.ForeColor = System.Drawing.Color.White;
            this.pnlTime.Location = new System.Drawing.Point(0, 0);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(1040, 22);
            this.pnlTime.TabIndex = 9;
            // 
            // pnlDream
            // 
            this.pnlDream.BackColor = System.Drawing.Color.Transparent;
            this.pnlDream.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDream.BackgroundImage")));
            this.pnlDream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDream.Location = new System.Drawing.Point(76, 1);
            this.pnlDream.Name = "pnlDream";
            this.pnlDream.Size = new System.Drawing.Size(81, 22);
            this.pnlDream.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::OnlineBookStore.Properties.Resources.criss_cross1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Location = new System.Drawing.Point(1017, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(923, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 21);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(823, 1);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 21);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "DD/MM/YY";
            // 
            // timerWelcomeString
            // 
            this.timerWelcomeString.Interval = 250;
            this.timerWelcomeString.Tick += new System.EventHandler(this.timerWelcomeString_Tick);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.CausesValidation = false;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(188, 49);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(852, 675);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlSelectedButton
            // 
            this.pnlSelectedButton.BackColor = System.Drawing.Color.White;
            this.pnlSelectedButton.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectedButton.Name = "pnlSelectedButton";
            this.pnlSelectedButton.Size = new System.Drawing.Size(10, 60);
            this.pnlSelectedButton.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 723);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlStatus);
            this.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnMusicCDs;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timerWelcomeString;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnMyCart;
        private System.Windows.Forms.Panel pnlBookStore;
        private System.Windows.Forms.Panel pnlDream;
        private System.Windows.Forms.Button btnSetting;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlSelectedButton;
    }
}