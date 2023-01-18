namespace TradingApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tradingTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradingTicketToolStripMenuItem,
            this.blotterToolStripMenuItem,
            this.allocationToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.dailyToolStripMenuItem,
            this.portfolioManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tradingTicketToolStripMenuItem
            // 
            this.tradingTicketToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.tradingTicketToolStripMenuItem.Name = "tradingTicketToolStripMenuItem";
            this.tradingTicketToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.tradingTicketToolStripMenuItem.Text = "Trading ticket";
            this.tradingTicketToolStripMenuItem.Click += new System.EventHandler(this.tradingTicketToolStripMenuItem_Click);
            // 
            // blotterToolStripMenuItem
            // 
            this.blotterToolStripMenuItem.Name = "blotterToolStripMenuItem";
            this.blotterToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.blotterToolStripMenuItem.Text = "Blotter";
            this.blotterToolStripMenuItem.Click += new System.EventHandler(this.blotterToolStripMenuItem_Click);
            // 
            // allocationToolStripMenuItem
            // 
            this.allocationToolStripMenuItem.Name = "allocationToolStripMenuItem";
            this.allocationToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.allocationToolStripMenuItem.Text = "Allocation";
            this.allocationToolStripMenuItem.Click += new System.EventHandler(this.allocationToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.closingToolStripMenuItem.Text = "Closing";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.dailyToolStripMenuItem.Text = "Daily Valuation";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
            // 
            // portfolioManagementToolStripMenuItem
            // 
            this.portfolioManagementToolStripMenuItem.Name = "portfolioManagementToolStripMenuItem";
            this.portfolioManagementToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
            this.portfolioManagementToolStripMenuItem.Text = "Portfolio Management";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 29);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Nirvana";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tradingTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioManagementToolStripMenuItem;
    }
}