namespace OnlineBookStore
{
    partial class UC_Books
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
            this.flowLayoutBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutBooks
            // 
            this.flowLayoutBooks.AutoScroll = true;
            this.flowLayoutBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutBooks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutBooks.Name = "flowLayoutBooks";
            this.flowLayoutBooks.Size = new System.Drawing.Size(1020, 684);
            this.flowLayoutBooks.TabIndex = 2;
            // 
            // UC_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutBooks);
            this.Name = "UC_Books";
            this.Size = new System.Drawing.Size(1020, 684);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowLayoutBooks;
    }
}
