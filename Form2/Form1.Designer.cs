namespace Form2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tradingTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blotterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradingTicketToolStripMenuItem,
            this.blotterToolStripMenuItem1,
            this.allocationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tradingTicketToolStripMenuItem
            // 
            this.tradingTicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blotterToolStripMenuItem});
            this.tradingTicketToolStripMenuItem.Name = "tradingTicketToolStripMenuItem";
            this.tradingTicketToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.tradingTicketToolStripMenuItem.Text = "trading ticket";
            // 
            // blotterToolStripMenuItem
            // 
            this.blotterToolStripMenuItem.Name = "blotterToolStripMenuItem";
            this.blotterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blotterToolStripMenuItem.Text = "blotter";
            // 
            // blotterToolStripMenuItem1
            // 
            this.blotterToolStripMenuItem1.Name = "blotterToolStripMenuItem1";
            this.blotterToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.blotterToolStripMenuItem1.Text = "blotter";
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.allocationToolStripMenuItem.Text = "allocation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tradingTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blotterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
    }
}

