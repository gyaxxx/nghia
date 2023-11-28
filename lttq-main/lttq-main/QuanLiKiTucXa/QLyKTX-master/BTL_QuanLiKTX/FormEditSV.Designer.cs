namespace BTL_QuanLiKTX
{
	partial class FormEditSV
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
			this.dgvDSSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.qLKyTucXa = new BTL_QuanLiKTX.QLKyTucXa();
			this.sinhVienTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.SinhVienTableAdapter();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txtToiDa = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtDango = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbMaPhong = new System.Windows.Forms.ComboBox();
			this.txtTienThue = new System.Windows.Forms.TextBox();
			this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
			this.txtMathue = new System.Windows.Forms.TextBox();
			this.dtpNgayBĐ = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.cmbMaLop = new System.Windows.Forms.ComboBox();
			this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbMaQue = new System.Windows.Forms.ComboBox();
			this.queBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtTensv = new System.Windows.Forms.TextBox();
			this.txtMasv = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.khoaTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.KhoaTableAdapter();
			this.queTableAdapter = new BTL_QuanLiKTX.QLKyTucXaTableAdapters.QueTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).BeginInit();
			this.guna2GroupBox2.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDSSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvDSSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSSinhVien.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
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
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDSSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDSSinhVien.Location = new System.Drawing.Point(14, 14);
			this.dgvDSSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvDSSinhVien.Name = "dgvDSSinhVien";
			this.dgvDSSinhVien.RowHeadersVisible = false;
			this.dgvDSSinhVien.RowHeadersWidth = 51;
			this.dgvDSSinhVien.Size = new System.Drawing.Size(905, 210);
			this.dgvDSSinhVien.TabIndex = 2;
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
			this.sinhVienBindingSource.DataSource = this.qLKyTucXa;
			// 
			// qLKyTucXa
			// 
			this.qLKyTucXa.DataSetName = "QLKyTucXa";
			this.qLKyTucXa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHuy.Location = new System.Drawing.Point(486, 623);
			this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(149, 37);
			this.btnHuy.TabIndex = 10;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSua.Location = new System.Drawing.Point(298, 623);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(149, 37);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa thông tin";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.txtToiDa);
			this.guna2GroupBox2.Controls.Add(this.label14);
			this.guna2GroupBox2.Controls.Add(this.txtDango);
			this.guna2GroupBox2.Controls.Add(this.label13);
			this.guna2GroupBox2.Controls.Add(this.cmbMaPhong);
			this.guna2GroupBox2.Controls.Add(this.txtTienThue);
			this.guna2GroupBox2.Controls.Add(this.dtpNgayKT);
			this.guna2GroupBox2.Controls.Add(this.txtMathue);
			this.guna2GroupBox2.Controls.Add(this.dtpNgayBĐ);
			this.guna2GroupBox2.Controls.Add(this.label8);
			this.guna2GroupBox2.Controls.Add(this.label9);
			this.guna2GroupBox2.Controls.Add(this.label10);
			this.guna2GroupBox2.Controls.Add(this.label11);
			this.guna2GroupBox2.Controls.Add(this.label12);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox2.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(486, 232);
			this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(433, 365);
			this.guna2GroupBox2.TabIndex = 8;
			this.guna2GroupBox2.Text = "Thông Tin Đăng Ký Phòng Thuê";
			// 
			// txtToiDa
			// 
			this.txtToiDa.Location = new System.Drawing.Point(190, 375);
			this.txtToiDa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtToiDa.Name = "txtToiDa";
			this.txtToiDa.Size = new System.Drawing.Size(224, 35);
			this.txtToiDa.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(4, 379);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(180, 26);
			this.label14.TabIndex = 19;
			this.label14.Text = "Số người tối đa :";
			// 
			// txtDango
			// 
			this.txtDango.Location = new System.Drawing.Point(190, 325);
			this.txtDango.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDango.Name = "txtDango";
			this.txtDango.Size = new System.Drawing.Size(224, 35);
			this.txtDango.TabIndex = 18;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(4, 329);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(191, 26);
			this.label13.TabIndex = 17;
			this.label13.Text = "Số người đang ở :";
			// 
			// cmbMaPhong
			// 
			this.cmbMaPhong.FormattingEnabled = true;
			this.cmbMaPhong.Location = new System.Drawing.Point(161, 110);
			this.cmbMaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaPhong.Name = "cmbMaPhong";
			this.cmbMaPhong.Size = new System.Drawing.Size(254, 34);
			this.cmbMaPhong.TabIndex = 14;
			this.cmbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cmbMaPhong_SelectedIndexChanged);
			// 
			// txtTienThue
			// 
			this.txtTienThue.Location = new System.Drawing.Point(161, 274);
			this.txtTienThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTienThue.Name = "txtTienThue";
			this.txtTienThue.Size = new System.Drawing.Size(254, 35);
			this.txtTienThue.TabIndex = 16;
			// 
			// dtpNgayKT
			// 
			this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayKT.Location = new System.Drawing.Point(161, 220);
			this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgayKT.Name = "dtpNgayKT";
			this.dtpNgayKT.Size = new System.Drawing.Size(254, 35);
			this.dtpNgayKT.TabIndex = 15;
			// 
			// txtMathue
			// 
			this.txtMathue.Location = new System.Drawing.Point(161, 58);
			this.txtMathue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMathue.Name = "txtMathue";
			this.txtMathue.Size = new System.Drawing.Size(254, 35);
			this.txtMathue.TabIndex = 14;
			// 
			// dtpNgayBĐ
			// 
			this.dtpNgayBĐ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayBĐ.Location = new System.Drawing.Point(161, 163);
			this.dtpNgayBĐ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgayBĐ.Name = "dtpNgayBĐ";
			this.dtpNgayBĐ.Size = new System.Drawing.Size(254, 35);
			this.dtpNgayBĐ.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(4, 223);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(168, 26);
			this.label8.TabIndex = 11;
			this.label8.Text = "Ngày kết thúc :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(4, 277);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 26);
			this.label9.TabIndex = 10;
			this.label9.Text = "Tiền thuê :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(4, 119);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 26);
			this.label10.TabIndex = 9;
			this.label10.Text = "Mã phòng :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(4, 65);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(139, 26);
			this.label11.TabIndex = 8;
			this.label11.Text = "Mã số thuê :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(4, 169);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(162, 26);
			this.label12.TabIndex = 7;
			this.label12.Text = "Ngày bắt đầu :";
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.cmbMaLop);
			this.guna2GroupBox1.Controls.Add(this.cmbMaKhoa);
			this.guna2GroupBox1.Controls.Add(this.cmbMaQue);
			this.guna2GroupBox1.Controls.Add(this.cmbGioiTinh);
			this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
			this.guna2GroupBox1.Controls.Add(this.txtTensv);
			this.guna2GroupBox1.Controls.Add(this.txtMasv);
			this.guna2GroupBox1.Controls.Add(this.label7);
			this.guna2GroupBox1.Controls.Add(this.label6);
			this.guna2GroupBox1.Controls.Add(this.label5);
			this.guna2GroupBox1.Controls.Add(this.label4);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.Controls.Add(this.label1);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SlateBlue;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(14, 232);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(433, 365);
			this.guna2GroupBox1.TabIndex = 7;
			this.guna2GroupBox1.Text = "Thông Tin Sinh Viên";
			// 
			// cmbMaLop
			// 
			this.cmbMaLop.FormattingEnabled = true;
			this.cmbMaLop.Location = new System.Drawing.Point(156, 375);
			this.cmbMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaLop.Name = "cmbMaLop";
			this.cmbMaLop.Size = new System.Drawing.Size(261, 34);
			this.cmbMaLop.TabIndex = 13;
			// 
			// cmbMaKhoa
			// 
			this.cmbMaKhoa.DataSource = this.khoaBindingSource;
			this.cmbMaKhoa.DisplayMember = "Makhoa";
			this.cmbMaKhoa.FormattingEnabled = true;
			this.cmbMaKhoa.Location = new System.Drawing.Point(156, 316);
			this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaKhoa.Name = "cmbMaKhoa";
			this.cmbMaKhoa.Size = new System.Drawing.Size(261, 34);
			this.cmbMaKhoa.TabIndex = 12;
			this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.qLKyTucXa;
			// 
			// cmbMaQue
			// 
			this.cmbMaQue.DataSource = this.queBindingSource;
			this.cmbMaQue.DisplayMember = "Maque";
			this.cmbMaQue.FormattingEnabled = true;
			this.cmbMaQue.Location = new System.Drawing.Point(156, 265);
			this.cmbMaQue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbMaQue.Name = "cmbMaQue";
			this.cmbMaQue.Size = new System.Drawing.Size(261, 34);
			this.cmbMaQue.TabIndex = 11;
			// 
			// queBindingSource
			// 
			this.queBindingSource.DataMember = "Que";
			this.queBindingSource.DataSource = this.qLKyTucXa;
			// 
			// cmbGioiTinh
			// 
			this.cmbGioiTinh.FormattingEnabled = true;
			this.cmbGioiTinh.Location = new System.Drawing.Point(156, 211);
			this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbGioiTinh.Name = "cmbGioiTinh";
			this.cmbGioiTinh.Size = new System.Drawing.Size(261, 34);
			this.cmbGioiTinh.TabIndex = 10;
			this.cmbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cmbGioiTinh_SelectedIndexChanged);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(156, 160);
			this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(261, 35);
			this.dtpNgaySinh.TabIndex = 9;
			// 
			// txtTensv
			// 
			this.txtTensv.Location = new System.Drawing.Point(156, 105);
			this.txtTensv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTensv.Name = "txtTensv";
			this.txtTensv.Size = new System.Drawing.Size(261, 35);
			this.txtTensv.TabIndex = 8;
			// 
			// txtMasv
			// 
			this.txtMasv.Location = new System.Drawing.Point(156, 58);
			this.txtMasv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMasv.Name = "txtMasv";
			this.txtMasv.Size = new System.Drawing.Size(261, 35);
			this.txtMasv.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(4, 325);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 26);
			this.label7.TabIndex = 6;
			this.label7.Text = "Mã khoa :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(4, 385);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mã lớp :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(4, 274);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 26);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mã quê :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(4, 220);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giới tính :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(4, 169);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(4, 113);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên sinh viên :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(4, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã sinh viên :";
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// queTableAdapter
			// 
			this.queTableAdapter.ClearBeforeFill = true;
			// 
			// FormEditSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 660);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.dgvDSSinhVien);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormEditSV";
			this.Text = "FormEditSV";
			this.Load += new System.EventHandler(this.FormEditSV_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLKyTucXa)).EndInit();
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox2.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.queBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView dgvDSSinhVien;
		private QLKyTucXa qLKyTucXa;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private QLKyTucXaTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maqueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnSua;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private System.Windows.Forms.TextBox txtToiDa;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtDango;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbMaPhong;
		private System.Windows.Forms.TextBox txtTienThue;
		private System.Windows.Forms.DateTimePicker dtpNgayKT;
		private System.Windows.Forms.TextBox txtMathue;
		private System.Windows.Forms.DateTimePicker dtpNgayBĐ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.ComboBox cmbMaLop;
		private System.Windows.Forms.ComboBox cmbMaKhoa;
		private System.Windows.Forms.ComboBox cmbMaQue;
		private System.Windows.Forms.ComboBox cmbGioiTinh;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtTensv;
		private System.Windows.Forms.TextBox txtMasv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private QLKyTucXaTableAdapters.KhoaTableAdapter khoaTableAdapter;
		private System.Windows.Forms.BindingSource queBindingSource;
		private QLKyTucXaTableAdapters.QueTableAdapter queTableAdapter;
	}
}