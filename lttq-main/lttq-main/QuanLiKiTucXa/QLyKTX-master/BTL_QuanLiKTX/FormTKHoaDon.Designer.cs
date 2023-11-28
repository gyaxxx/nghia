namespace BTL_QuanLiKTX
{
	partial class FormTKHoaDon
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txt_mahoadon = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvTimThuePhong = new Guna.UI2.WinForms.Guna2DataGridView();
			this.qLKyTucXaDataSet = new BTL_QuanLiKTX.QLKyTucXaDataSet();
			this.thuephongBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.thuephongTableAdapter = new BTL_QuanLiKTX.QLKyTucXaDataSetTableAdapters.ThuephongTableAdapter();
			this.masothueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayBdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MaPhong = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_MaSinhVien = new Guna.UI2.WinForms.Guna2TextBox();
			this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimThuePhong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.thuephongBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_mahoadon
			// 
			this.txt_mahoadon.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_mahoadon.DefaultText = "";
			this.txt_mahoadon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_mahoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_mahoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_mahoadon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_mahoadon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_mahoadon.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_mahoadon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_mahoadon.Location = new System.Drawing.Point(189, 31);
			this.txt_mahoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_mahoadon.Name = "txt_mahoadon";
			this.txt_mahoadon.PasswordChar = '\0';
			this.txt_mahoadon.PlaceholderText = "";
			this.txt_mahoadon.SelectedText = "";
			this.txt_mahoadon.Size = new System.Drawing.Size(536, 48);
			this.txt_mahoadon.TabIndex = 0;
			this.txt_mahoadon.TextChanged += new System.EventHandler(this.txt_mahoadon_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã số thuê";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dgvTimThuePhong
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dgvTimThuePhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvTimThuePhong.AutoGenerateColumns = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTimThuePhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvTimThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masothueDataGridViewTextBoxColumn,
            this.masvDataGridViewTextBoxColumn,
            this.maphongDataGridViewTextBoxColumn,
            this.ngayBdauDataGridViewTextBoxColumn,
            this.ngayktDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
			this.dgvTimThuePhong.DataSource = this.thuephongBindingSource;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTimThuePhong.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvTimThuePhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvTimThuePhong.Location = new System.Drawing.Point(12, 268);
			this.dgvTimThuePhong.Name = "dgvTimThuePhong";
			this.dgvTimThuePhong.RowHeadersVisible = false;
			this.dgvTimThuePhong.RowHeadersWidth = 51;
			this.dgvTimThuePhong.RowTemplate.Height = 24;
			this.dgvTimThuePhong.Size = new System.Drawing.Size(919, 255);
			this.dgvTimThuePhong.TabIndex = 3;
			this.dgvTimThuePhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvTimThuePhong.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvTimThuePhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvTimThuePhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvTimThuePhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvTimThuePhong.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvTimThuePhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimThuePhong.ThemeStyle.HeaderStyle.Height = 18;
			this.dgvTimThuePhong.ThemeStyle.ReadOnly = false;
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.Height = 24;
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvTimThuePhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvTimThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimThuePhong_CellContentClick);
			// 
			// qLKyTucXaDataSet
			// 
			this.qLKyTucXaDataSet.DataSetName = "QLKyTucXaDataSet";
			this.qLKyTucXaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// thuephongBindingSource
			// 
			this.thuephongBindingSource.DataMember = "Thuephong";
			this.thuephongBindingSource.DataSource = this.qLKyTucXaDataSet;
			// 
			// thuephongTableAdapter
			// 
			this.thuephongTableAdapter.ClearBeforeFill = true;
			// 
			// masothueDataGridViewTextBoxColumn
			// 
			this.masothueDataGridViewTextBoxColumn.DataPropertyName = "Masothue";
			this.masothueDataGridViewTextBoxColumn.HeaderText = "Masothue";
			this.masothueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masothueDataGridViewTextBoxColumn.Name = "masothueDataGridViewTextBoxColumn";
			// 
			// masvDataGridViewTextBoxColumn
			// 
			this.masvDataGridViewTextBoxColumn.DataPropertyName = "Masv";
			this.masvDataGridViewTextBoxColumn.HeaderText = "Masv";
			this.masvDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
			// 
			// maphongDataGridViewTextBoxColumn
			// 
			this.maphongDataGridViewTextBoxColumn.DataPropertyName = "Maphong";
			this.maphongDataGridViewTextBoxColumn.HeaderText = "Maphong";
			this.maphongDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.maphongDataGridViewTextBoxColumn.Name = "maphongDataGridViewTextBoxColumn";
			// 
			// ngayBdauDataGridViewTextBoxColumn
			// 
			this.ngayBdauDataGridViewTextBoxColumn.DataPropertyName = "NgayBdau";
			this.ngayBdauDataGridViewTextBoxColumn.HeaderText = "NgayBdau";
			this.ngayBdauDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngayBdauDataGridViewTextBoxColumn.Name = "ngayBdauDataGridViewTextBoxColumn";
			// 
			// ngayktDataGridViewTextBoxColumn
			// 
			this.ngayktDataGridViewTextBoxColumn.DataPropertyName = "Ngaykt";
			this.ngayktDataGridViewTextBoxColumn.HeaderText = "Ngaykt";
			this.ngayktDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ngayktDataGridViewTextBoxColumn.Name = "ngayktDataGridViewTextBoxColumn";
			// 
			// ghichuDataGridViewTextBoxColumn
			// 
			this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghichu";
			this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã phòng";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mã sinh viên";
			// 
			// txt_MaPhong
			// 
			this.txt_MaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaPhong.DefaultText = "";
			this.txt_MaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_MaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaPhong.Location = new System.Drawing.Point(189, 109);
			this.txt_MaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_MaPhong.Name = "txt_MaPhong";
			this.txt_MaPhong.PasswordChar = '\0';
			this.txt_MaPhong.PlaceholderText = "";
			this.txt_MaPhong.SelectedText = "";
			this.txt_MaPhong.Size = new System.Drawing.Size(536, 48);
			this.txt_MaPhong.TabIndex = 5;
			this.txt_MaPhong.TextChanged += new System.EventHandler(this.txt_MaPhong_TextChanged);
			// 
			// txt_MaSinhVien
			// 
			this.txt_MaSinhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaSinhVien.DefaultText = "";
			this.txt_MaSinhVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaSinhVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaSinhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_MaSinhVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaSinhVien.Location = new System.Drawing.Point(189, 196);
			this.txt_MaSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_MaSinhVien.Name = "txt_MaSinhVien";
			this.txt_MaSinhVien.PasswordChar = '\0';
			this.txt_MaSinhVien.PlaceholderText = "";
			this.txt_MaSinhVien.SelectedText = "";
			this.txt_MaSinhVien.Size = new System.Drawing.Size(536, 48);
			this.txt_MaSinhVien.TabIndex = 6;
			// 
			// btn_TimKiem
			// 
			this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
			this.btn_TimKiem.Location = new System.Drawing.Point(762, 84);
			this.btn_TimKiem.Name = "btn_TimKiem";
			this.btn_TimKiem.Size = new System.Drawing.Size(180, 45);
			this.btn_TimKiem.TabIndex = 7;
			this.btn_TimKiem.Text = "Tìm kiếm";
			this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
			// 
			// guna2Button1
			// 
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(762, 156);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(180, 45);
			this.guna2Button1.TabIndex = 8;
			this.guna2Button1.Text = "Thoát";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// FormTKHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 535);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.btn_TimKiem);
			this.Controls.Add(this.txt_MaSinhVien);
			this.Controls.Add(this.txt_MaPhong);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvTimThuePhong);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_mahoadon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTKHoaDon";
			this.Text = "FormTKHoaDon";
			this.Load += new System.EventHandler(this.FormTKHoaDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimThuePhong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.thuephongBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txt_mahoadon;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvTimThuePhong;
		private QLKyTucXaDataSet qLKyTucXaDataSet;
		private System.Windows.Forms.BindingSource thuephongBindingSource;
		private QLKyTucXaDataSetTableAdapters.ThuephongTableAdapter thuephongTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masothueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayBdauDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngayktDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaPhong;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaSinhVien;
		private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}