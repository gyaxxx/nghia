namespace BTL_QuanLiKTX
{
	partial class FormQLHoaDon
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
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thuTiềnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.loadFunctionHD = new Guna.UI2.WinForms.Guna2Panel();
			this.loadPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.loadFunctionHD.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.bToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(966, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmHóaĐơnToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tìmKiếmHóaĐơnToolStripMenuItem
			// 
			this.tìmKiếmHóaĐơnToolStripMenuItem.Name = "tìmKiếmHóaĐơnToolStripMenuItem";
			this.tìmKiếmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.tìmKiếmHóaĐơnToolStripMenuItem.Text = "Tìm kiếm hóa đơn";
			this.tìmKiếmHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHóaĐơnToolStripMenuItem_Click_1);
			// 
			// bToolStripMenuItem
			// 
			this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuTiềnPhòngToolStripMenuItem,
            this.thuêPhòngToolStripMenuItem});
			this.bToolStripMenuItem.Name = "bToolStripMenuItem";
			this.bToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.bToolStripMenuItem.Text = "Bảng";
			// 
			// thuTiềnPhòngToolStripMenuItem
			// 
			this.thuTiềnPhòngToolStripMenuItem.Name = "thuTiềnPhòngToolStripMenuItem";
			this.thuTiềnPhòngToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.thuTiềnPhòngToolStripMenuItem.Text = "Thu tiền phòng";
			this.thuTiềnPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuTiềnPhòngToolStripMenuItem_Click);
			// 
			// thuêPhòngToolStripMenuItem
			// 
			this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
			this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
			this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(966, 69);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(376, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lí hóa đơn";
			// 
			// loadFunctionHD
			// 
			this.loadFunctionHD.Controls.Add(this.loadPanel);
			this.loadFunctionHD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadFunctionHD.Location = new System.Drawing.Point(0, 93);
			this.loadFunctionHD.Name = "loadFunctionHD";
			this.loadFunctionHD.Size = new System.Drawing.Size(966, 516);
			this.loadFunctionHD.TabIndex = 1;
			this.loadFunctionHD.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
			// 
			// loadPanel
			// 
			this.loadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadPanel.Location = new System.Drawing.Point(0, 0);
			this.loadPanel.Name = "loadPanel";
			this.loadPanel.Size = new System.Drawing.Size(966, 516);
			this.loadPanel.TabIndex = 6;
			this.loadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint_1);
			// 
			// FormQLHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 609);
			this.Controls.Add(this.loadFunctionHD);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormQLHoaDon";
			this.Text = "FormQLHoaDon";
			this.Load += new System.EventHandler(this.FormQLHoaDon_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.loadFunctionHD.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmHóaĐơnToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thuTiềnPhòngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2Panel loadFunctionHD;
		private Guna.UI2.WinForms.Guna2Panel loadPanel;
	}
}