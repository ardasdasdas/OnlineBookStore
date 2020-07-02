namespace OnlineBookStore
{
    partial class UC_MusicCDs
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
            this.flowLayoutMusicCDs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutMusicCDs
            // 
            this.flowLayoutMusicCDs.AutoScroll = true;
            this.flowLayoutMusicCDs.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutMusicCDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMusicCDs.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMusicCDs.Name = "flowLayoutMusicCDs";
            this.flowLayoutMusicCDs.Size = new System.Drawing.Size(1020, 684);
            this.flowLayoutMusicCDs.TabIndex = 16;
            // 
            // UC_MusicCDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutMusicCDs);
            this.Name = "UC_MusicCDs";
            this.Size = new System.Drawing.Size(1020, 684);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowLayoutMusicCDs;
    }
}
