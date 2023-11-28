namespace BTL_QuanLiKTX
{
	partial class FormMainQLSV
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tìmKiếmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dbQLSVDataSet = new BTL_QuanLiKTX.dbQLSVDataSet();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnLivingKTX = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.dbQLSVDataSetTableAdapters.SinhVienTableAdapter();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1288, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSinhViênToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem});
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
			this.chứcNăngToolStripMenuItem.Text = "Chức năng";
			// 
			// tìmKiếmSinhViênToolStripMenuItem
			// 
			this.tìmKiếmSinhViênToolStripMenuItem.Name = "tìmKiếmSinhViênToolStripMenuItem";
			this.tìmKiếmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.tìmKiếmSinhViênToolStripMenuItem.Text = "Tìm kiếm sinh viên";
			this.tìmKiếmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmSinhViênToolStripMenuItem_Click);
			// 
			// thêmToolStripMenuItem
			// 
			this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
			this.thêmToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.thêmToolStripMenuItem.Text = "Thêm Sinh Viên";
			this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
			// 
			// sửaToolStripMenuItem
			// 
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.sửaToolStripMenuItem.Text = "Sửa Thông Tin Sinh Viên";
			this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
			// 
			// xuấtExcelToolStripMenuItem
			// 
			this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
			this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel DS Sinh Viên";
			this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDSSinhVien.ColumnHeadersHeight = 15;
			this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.maqueDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
			this.dgvDSSinhVien.DataSource = this.sinhVienBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(16, 121);
			this.dgvDSSinhVien.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.RowHeadersWidth = 51;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(1259, 559);
			this.dgvDSSinhVien.TabIndex = 1;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDSSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDSSinhVien.ThemeStyle.HeaderStyle.Height = 15;
			this.dgvDSSinhVien.ThemeStyle.ReadOnly = false;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.Height = 22;
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvDSSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSinhVien_CellContentClick);
			// 
			// masinhvienDataGridViewTextBoxColumn
			// 
			this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Masinhvien";
			this.masinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
			// 
			// tensinhvienDataGridViewTextBoxColumn
			// 
			this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tensinhvien";
			this.tensinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
			// 
			// ngaysinhDataGridViewTextBoxColumn
			// 
			this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
			this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
			// 
			// gioitinhDataGridViewTextBoxColumn
			// 
			this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Gioitinh";
			this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
			// 
			// maqueDataGridViewTextBoxColumn
			// 
			this.maqueDataGridViewTextBoxColumn.DataPropertyName = "Maque";
			this.maqueDataGridViewTextBoxColumn.HeaderText = "Maque";
			this.maqueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maqueDataGridViewTextBoxColumn.Name = "maqueDataGridViewTextBoxColumn";
			// 
			// makhoaDataGridViewTextBoxColumn
			// 
			this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.HeaderText = "Makhoa";
			this.makhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
			// 
			// malopDataGridViewTextBoxColumn
			// 
			this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
			this.malopDataGridViewTextBoxColumn.HeaderText = "Malop";
			this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.dbQLSVDataSet;
			// 
			// dbQLSVDataSet
			// 
			this.dbQLSVDataSet.DataSetName = "dbQLSVDataSet";
			this.dbQLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAll.Location = new System.Drawing.Point(439, 700);
			this.btnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(171, 39);
			this.btnAll.TabIndex = 9;
			this.btnAll.Text = "Tất Cả";
			this.btnAll.UseVisualStyleBackColor = false;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnLivingKTX
			// 
			this.btnLivingKTX.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnLivingKTX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLivingKTX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLivingKTX.Location = new System.Drawing.Point(690, 700);
			this.btnLivingKTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLivingKTX.Name = "btnLivingKTX";
			this.btnLivingKTX.Size = new System.Drawing.Size(171, 39);
			this.btnLivingKTX.TabIndex = 8;
			this.btnLivingKTX.Text = "Đang ở KTX";
			this.btnLivingKTX.UseVisualStyleBackColor = false;
			this.btnLivingKTX.Click += new System.EventHandler(this.btnLivingKTX_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1288, 85);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(501, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(313, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lí sinh viên";
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// FormMainQLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1288, 750);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnLivingKTX);
			this.Controls.Add(this.dgvDSSinhVien);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMainQLSV";
			this.Text = "FormMainQLSV";
			this.Load += new System.EventHandler(this.FormMainQLSV_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tìmKiếmSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnLivingKTX;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private dbQLSVDataSet dbQLSVDataSet;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private dbQLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maqueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
	}
}