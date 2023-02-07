namespace QLKho_app
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLObject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setting = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLoadMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLCustomerToolStripMenuItem,
            this.qLUnitToolStripMenuItem,
            this.QLObject,
            this.toolStripMenuItem1,
            this.setting,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1717, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLCustomerToolStripMenuItem
            // 
            this.qLCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.qLCustomerToolStripMenuItem.Name = "qLCustomerToolStripMenuItem";
            this.qLCustomerToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.qLCustomerToolStripMenuItem.Text = "QLCustomer";
            this.qLCustomerToolStripMenuItem.Click += new System.EventHandler(this.qLCustomerToolStripMenuItem_Click);
            // 
            // qLUnitToolStripMenuItem
            // 
            this.qLUnitToolStripMenuItem.Name = "qLUnitToolStripMenuItem";
            this.qLUnitToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.qLUnitToolStripMenuItem.Text = "QLUnit";
            this.qLUnitToolStripMenuItem.Click += new System.EventHandler(this.qLUnitToolStripMenuItem_Click);
            // 
            // QLObject
            // 
            this.QLObject.Name = "QLObject";
            this.QLObject.Size = new System.Drawing.Size(84, 24);
            this.QLObject.Text = "QLObject";
            this.QLObject.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // setting
            // 
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(70, 24);
            this.setting.Text = "Cài đặt";
            this.setting.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(87, 24);
            this.about.Text = "Giới thiệu";
            // 
            // pnlLoadMain
            // 
            this.pnlLoadMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLoadMain.Location = new System.Drawing.Point(0, 31);
            this.pnlLoadMain.Name = "pnlLoadMain";
            this.pnlLoadMain.Size = new System.Drawing.Size(1717, 654);
            this.pnlLoadMain.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 681);
            this.Controls.Add(this.pnlLoadMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "HỆ THỐNG QUẢN LÍ KHO DƯỢC";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qLCustomerToolStripMenuItem;
        private ToolStripMenuItem qLUnitToolStripMenuItem;
        private Panel pnlLoadMain;
        private ToolStripMenuItem QLObject;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem setting;
        private ToolStripMenuItem about;
    }
}