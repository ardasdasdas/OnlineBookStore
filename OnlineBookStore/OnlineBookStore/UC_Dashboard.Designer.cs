namespace OnlineBookStore
{
    partial class UC_Dashboard
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
            this.pnlEditorsChoice = new System.Windows.Forms.Panel();
            this.lblEditorsChoice = new System.Windows.Forms.Label();
            this.flowLayoutEditorsChoice = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEditorsChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditorsChoice
            // 
            this.pnlEditorsChoice.Controls.Add(this.lblEditorsChoice);
            this.pnlEditorsChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditorsChoice.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorsChoice.Name = "pnlEditorsChoice";
            this.pnlEditorsChoice.Size = new System.Drawing.Size(826, 60);
            this.pnlEditorsChoice.TabIndex = 14;
            // 
            // lblEditorsChoice
            // 
            this.lblEditorsChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditorsChoice.AutoSize = true;
            this.lblEditorsChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblEditorsChoice.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEditorsChoice.ForeColor = System.Drawing.Color.Tomato;
            this.lblEditorsChoice.Location = new System.Drawing.Point(219, 14);
            this.lblEditorsChoice.Name = "lblEditorsChoice";
            this.lblEditorsChoice.Size = new System.Drawing.Size(424, 46);
            this.lblEditorsChoice.TabIndex = 13;
            this.lblEditorsChoice.Text = "Here is the Editor\'s Choices";
            // 
            // flowLayoutEditorsChoice
            // 
            this.flowLayoutEditorsChoice.AutoScroll = true;
            this.flowLayoutEditorsChoice.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutEditorsChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutEditorsChoice.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutEditorsChoice.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutEditorsChoice.Name = "flowLayoutEditorsChoice";
            this.flowLayoutEditorsChoice.Size = new System.Drawing.Size(826, 624);
            this.flowLayoutEditorsChoice.TabIndex = 15;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutEditorsChoice);
            this.Controls.Add(this.pnlEditorsChoice);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(826, 684);
            this.pnlEditorsChoice.ResumeLayout(false);
            this.pnlEditorsChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEditorsChoice;
        public System.Windows.Forms.Label lblEditorsChoice;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutEditorsChoice;
    }
}
