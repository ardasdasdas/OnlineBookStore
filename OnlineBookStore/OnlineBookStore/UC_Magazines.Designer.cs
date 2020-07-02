namespace OnlineBookStore
{
    partial class UC_Magazines
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
            this.flowLayoutMagazines = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutMagazines
            // 
            this.flowLayoutMagazines.AutoScroll = true;
            this.flowLayoutMagazines.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutMagazines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMagazines.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMagazines.Name = "flowLayoutMagazines";
            this.flowLayoutMagazines.Size = new System.Drawing.Size(1027, 684);
            this.flowLayoutMagazines.TabIndex = 18;
            // 
            // UC_Magazines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutMagazines);
            this.Name = "UC_Magazines";
            this.Size = new System.Drawing.Size(1027, 684);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutMagazines;
    }
}
