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
	public partial class FormThemSinhVien : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormThemSinhVien()
		{
			InitializeComponent();
		}

		private void FormThemSinhVien_Load(object sender, EventArgs e)
		{
			cmbGioiTinh.Items.Add("Nam");
			cmbGioiTinh.Items.Add("Nữ");
			cmbGioiTinh.Text = "";
			cmbMaQue.Text = "";
			cmbMaKhoa.Text = "";
			cmbMaLop.Text = "";
			cmbMaPhong.Text = "";
			cmbMaLop.Enabled = false;
			cmbMaPhong.Enabled = false;
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

		private void btnThem_Click(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();

			if (txtMasv.Text.Trim() == "") { errLoi.SetError(txtMasv, "Bạn không được để trống mã sinh viên!"); return; } else { errLoi.Clear(); }
			if (txtTensv.Text.Trim() == "") { errLoi.SetError(txtTensv, "Bạn không được để trống tên sinh viên!"); return; } else { errLoi.Clear(); }
			if (txtMathue.Text.Trim() == "") { errLoi.SetError(txtMathue, "Bạn không được để trống tên sinh viên!"); return; } else { errLoi.Clear(); }
			if (dtpNgaySinh.Value > DateTime.Now) { errLoi.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!"); return; } else { errLoi.Clear(); }
			if (dtpNgayBĐ.Value > dtpNgayKT.Value) { errLoi.SetError(dtpNgayBĐ, "Ngày bắt đầu phải trước ngày kết thúc!"); return; } else { errLoi.Clear(); }
			if (cmbGioiTinh.SelectedIndex == -1) { errLoi.SetError(cmbGioiTinh, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaQue.SelectedIndex == -1) { errLoi.SetError(cmbMaQue, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaKhoa.SelectedIndex == -1) { errLoi.SetError(cmbMaKhoa, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaLop.SelectedIndex == -1) { errLoi.SetError(cmbMaLop, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }
			if (cmbMaPhong.SelectedIndex == -1) { errLoi.SetError(cmbMaPhong, "Bạn phải chọn một lựa chọn!"); return; } else { errLoi.Clear(); }

			if (txtMasv.Text.Trim() == "") { errLoi.SetError(txtMasv, "Bạn không được để trống mã sinh viên!"); return; }
			else
			{
				sql = "Select Masinhvien From SinhVien Where Masinhvien =N'" + txtMasv.Text + "'";
				pd.DocBang(sql);
				if (pd.DocBang(sql).Rows.Count > 0)
				{
					errLoi.SetError(txtMasv, "Mã sinh viên trùng trong cơ sở dữ liệu");
					return;
				}
				errLoi.Clear();

				sql = "Select Masothue From Thuephong Where Masothue =N'" + txtMathue.Text + "'";
				pd.DocBang(sql);
				if (pd.DocBang(sql).Rows.Count > 0)
				{
					errLoi.SetError(txtMathue, "Mã số thuế trùng trong cơ sở dữ liệu");
					return;
				}
				errLoi.Clear();
			}
			sql = "INSERT INTO SinhVien(Masinhvien,Tensinhvien,Ngaysinh,Gioitinh,Maque,Makhoa,Malop)VALUES (";
			sql += "N'" + txtMasv.Text.Trim()
				+ "',N'" + txtTensv.Text.Trim()
				+ "','" + dtpNgaySinh.Value.Date.ToString("MM/dd/yyyy")
				+ "',N'" + cmbGioiTinh.Text
				+ "',N'" + cmbMaQue.Text
				+ "',N'" + cmbMaKhoa.Text
				+ "',N'" + cmbMaLop.Text + "')";
			pd.CapNhat(sql);

			sql = "INSERT INTO Thuephong(Masothue,Masv,Maphong,NgayBdau,Ngaykt)VALUES (";
			sql += "N'" + txtMathue.Text.Trim()
				+ "',N'" + txtMasv.Text.Trim()
				+ "','" + cmbMaPhong.Text
				+ "',N'" + dtpNgayBĐ.Value.Date.ToString("MM/dd/yyyy")
				+ "',N'" + dtpNgayKT.Value.Date.ToString("MM/dd/yyyy") + "')";
			pd.CapNhat(sql);

			sql = @"Update Phong set Songuoidango = Songuoidango + 1 
					Where Phong.MaPhong = N'" + cmbMaPhong.Text + @"'";
			pd.CapNhat(sql);

			this.Hide();
			FormMainQLSV main = new FormMainQLSV();
			main.ShowDialog();
			this.Close();
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
