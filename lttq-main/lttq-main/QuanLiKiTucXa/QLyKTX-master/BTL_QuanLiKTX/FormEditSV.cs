using ConnectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
	public partial class FormEditSV : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormEditSV()
		{
			InitializeComponent();
		}

		private void FormEditSV_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLKyTucXa.Que' table. You can move, or remove it, as needed.
			this.queTableAdapter.Fill(this.qLKyTucXa.Que);
			// TODO: This line of code loads data into the 'qLKyTucXa.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.qLKyTucXa.Khoa);
			// TODO: This line of code loads data into the 'qLKyTucXa.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.qLKyTucXa.SinhVien);
			cmbGioiTinh.Items.Add("Nam");
			cmbGioiTinh.Items.Add("Nữ");
			cmbGioiTinh.Text = "";
			cmbMaQue.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaLop.Text = "";
			cmbMaPhong.Text = "";
			btnSua.Enabled = false;
		}

		private void dgvDSSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua.Enabled = true;
			try
			{
				txtMasv.Text = dgvDSSinhVien[0, e.RowIndex].Value.ToString();
				txtTensv.Text = dgvDSSinhVien[1, e.RowIndex].Value.ToString();
				dtpNgaySinh.Value = (DateTime)dgvDSSinhVien[2, e.RowIndex].Value;
				cmbGioiTinh.Text = dgvDSSinhVien[3, e.RowIndex].Value.ToString();
				cmbMaQue.Text = dgvDSSinhVien[4, e.RowIndex].Value.ToString();
				cmbMaKhoa.Text = dgvDSSinhVien[5, e.RowIndex].Value.ToString();
				cmbMaLop.Text = dgvDSSinhVien[6, e.RowIndex].Value.ToString();				
			}
			catch (Exception ex)
			{
			}

			string sql = "";
			pd.KetNoi();
			sql = @"Select Thuephong.Masothue
				    From Thuephong join SinhVien on Thuephong.Masv = SinhVien.Masinhvien
				    Where SinhVien.Masinhvien = N'" + txtMasv.Text + @"'";
			DataTable result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtMathue.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Thuephong.Maphong
				    From Thuephong join SinhVien on Thuephong.Masv = SinhVien.Masinhvien
				    Where SinhVien.Masinhvien = N'" + txtMasv.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				cmbMaPhong.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Thuephong.NgayBdau
				    From Thuephong join SinhVien on Thuephong.Masv = SinhVien.Masinhvien
				    Where SinhVien.Masinhvien = N'" + txtMasv.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				dtpNgayBĐ.Value = (DateTime)result.Rows[0][0];
			}

			sql = @"Select Thuephong.Ngaykt
				    From Thuephong join SinhVien on Thuephong.Masv = SinhVien.Masinhvien
				    Where SinhVien.Masinhvien = N'" + txtMasv.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				dtpNgayKT.Value = (DateTime)result.Rows[0][0];
			}

			sql = @"Select Phong.Tienthue
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtTienThue.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Songuoidango
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtDango.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Songuoitoida
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtToiDa.Text = result.Rows[0][0].ToString();
			}

			txtTienThue.Enabled = false;
			txtDango.Enabled = false;
			txtToiDa.Enabled = false;
		}

		private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select SinhVien.Gioitinh, Phong.MaPhong
				    From SinhVien join Phong on SinhVien.Gioitinh = Phong.Loaiphong
				    Where SinhVien.Gioitinh = N'" + cmbGioiTinh.Text + @"'
						  AND Phong.Songuoidango < Phong.Songuoitoida
					Group by SinhVien.Gioitinh, Phong.MaPhong";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaPhong.DataSource = table;
			cmbMaPhong.DisplayMember = "MaPhong"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaPhong.ValueMember = "MaPhong"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaPhong.Enabled = true;
			cmbMaPhong.Text = "";
			txtDango.Text = "";
			txtToiDa.Text = "";
			txtTienThue.Text = "";
		}

		private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Khoa.Makhoa, Lop.Malop
				    From Khoa inner join Lop on Khoa.Makhoa = Lop.Makhoa
				    Where (Khoa.Makhoa = N'" + cmbMaKhoa.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaLop.DataSource = table;
			cmbMaLop.DisplayMember = "Malop"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaLop.ValueMember = "Malop"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaLop.Enabled = true;
			cmbMaLop.Text = "";
		}

		private void cmbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Phong.Songuoidango
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			DataTable result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtDango.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Songuoitoida
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtToiDa.Text = result.Rows[0][0].ToString();
			}

			sql = @"Select Phong.Tienthue
				    From Phong
				    Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);
			result = pd.DocBang(sql);
			if (result.Rows.Count > 0)
			{
				txtTienThue.Text = result.Rows[0][0].ToString();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql = "";
			sql = "Update SinhVien SET ";
			sql += "Tensinhvien = N'" + txtTensv.Text.Trim() + "',";
			sql += "Ngaysinh = '" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy") + "',";
			sql += "Gioitinh = N'" + cmbGioiTinh.Text + "',";
			sql += "Maque = N'" + cmbMaQue.Text + "',";
			sql += "Makhoa = '" + cmbMaKhoa.Text + "',";
			sql += "Malop = N'" + cmbMaLop.Text + "' ";
			sql += "Where Masinhvien = N'" + txtMasv.Text.Trim() + "'";
			pd.CapNhat(sql);

			sql = "Update Thuephong SET ";
			sql += "Masothue = N'" + txtMathue.Text.Trim() + "',";
			sql += "Maphong = '" + cmbMaPhong.Text + "',";
			sql += "NgayBdau = N'" + dtpNgayBĐ.Value.Date.ToString("MM/dd/yyyy") + "',";
			sql += "Ngaykt = N'" + dtpNgayKT.Value.Date.ToString("MM/dd/yyyy") + "',";
			sql += "Where Masv = N'" + txtMasv.Text.Trim() + "'";
			pd.CapNhat(sql);
			dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn hủy không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Hide();
				FormMainQLSV main = new FormMainQLSV();
				main.ShowDialog();
				this.Close();
			}
		}
	}
}
