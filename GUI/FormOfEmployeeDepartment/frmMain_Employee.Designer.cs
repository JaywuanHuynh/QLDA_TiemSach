﻿namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    partial class frmMain_Employee
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
            this.đăngKýThôngTinNhânViênMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlThucThi = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýThôngTinNhânViênMớiToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngKýThôngTinNhânViênMớiToolStripMenuItem
            // 
            this.đăngKýThôngTinNhânViênMớiToolStripMenuItem.Name = "đăngKýThôngTinNhânViênMớiToolStripMenuItem";
            this.đăngKýThôngTinNhânViênMớiToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.đăngKýThôngTinNhânViênMớiToolStripMenuItem.Text = "Đăng ký thông tin nhân viên";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // pnlThucThi
            // 
            this.pnlThucThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThucThi.Location = new System.Drawing.Point(0, 28);
            this.pnlThucThi.Name = "pnlThucThi";
            this.pnlThucThi.Size = new System.Drawing.Size(1050, 537);
            this.pnlThucThi.TabIndex = 1;
            // 
            // frmMain_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 565);
            this.Controls.Add(this.pnlThucThi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain_Employee";
            this.Text = "frmBoPhanNhanSu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngKýThôngTinNhânViênMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.Panel pnlThucThi;
    }
}