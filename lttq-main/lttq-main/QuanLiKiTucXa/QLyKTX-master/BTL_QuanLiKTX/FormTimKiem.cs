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
	public partial class FormTimKiem : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormTimKiem()
		{
			InitializeComponent();
		}

		private void FormTimKiem_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'qLKyTucXa.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLKyTucXa.Khoa);
            // TODO: This line of code loads data into the 'qLKyTucXa.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLKyTucXa.SinhVien);
			cmbGioiTinhTK.Items.Add("Nam");
			cmbGioiTinhTK.Items.Add("Nữ");
			cmbMaKhoaTK.Text = "";
			cmbMaLopTK.Text = "";
			cmbGioiTinhTK.Text = "";
			cmbMaPhongTK.Text = "";
			cmbMaKhoaTK.SelectedIndex = -1;
			cmbMaLopTK.SelectedIndex = -1;
			cmbGioiTinhTK.SelectedIndex = -1;
			cmbMaPhongTK.SelectedIndex = -1;
			cmbMaLopTK.Enabled = false;
			cmbMaPhongTK.Enabled = false;
		}

		private void cmbMaKhoaTK_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select Khoa.Makhoa, Lop.Malop
				    From Khoa inner join Lop on Khoa.Makhoa = Lop.Makhoa
				    Where (Khoa.Makhoa = N'" + cmbMaKhoaTK.Text + @"')";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaLopTK.DataSource = table;
			cmbMaLopTK.DisplayMember = "Malop"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaLopTK.ValueMember = "Malop"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaLopTK.Enabled = true;
			cmbMaLopTK.Text = "";
			cmbMaLopTK.SelectedIndex = -1;
		}

		private void cmbGioiTinhTK_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "";
			pd.KetNoi();
			sql = @"Select SinhVien.Gioitinh, Phong.MaPhong
				    From SinhVien join Phong on SinhVien.Gioitinh = Phong.Loaiphong
				    Where SinhVien.Gioitinh = N'" + cmbGioiTinhTK.Text + @"'						  
					Group by SinhVien.Gioitinh, Phong.MaPhong";
			pd.CapNhat(sql);
			DataTable table = pd.DocBang(sql);
			cmbMaPhongTK.DataSource = table;
			cmbMaPhongTK.DisplayMember = "MaPhong"; // Chọn cột dữ liệu để hiển thị trong ComboBox
			cmbMaPhongTK.ValueMember = "MaPhong"; // Chọn cột dữ liệu để làm giá trị thực của mỗi mục trong ComboBox
			cmbMaPhongTK.Enabled = true;
			cmbMaPhongTK.Text = "";
			cmbMaPhongTK.SelectedIndex = -1;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (cmbMaLopTK.SelectedIndex == -1 && cmbMaPhongTK.SelectedIndex == -1) { errLoi.SetError(cmbMaLopTK, "Bạn phải chọn 1 trong các lựa chọn dưới đây!"); errLoi.SetError(cmbMaPhongTK, "Bạn phải chọn 1 trong các lựa chọn dưới đây!"); return; } else { errLoi.Clear(); }
			string sql = "";
			pd.KetNoi();
			sql += @"Select SinhVien.*";
			String dk = "";
			//Tim theo Malop khac rong
			if (cmbMaLopTK.SelectedIndex != -1 && cmbMaPhongTK.SelectedIndex == -1)
			{
				sql += @"From SinhVien ";
				dk += @" Malop like N'%" + cmbMaLopTK.Text + @"%'";
			}
			//kiem tra Malop va Maphong khac rong
			if (cmbMaPhongTK.SelectedIndex != -1 && cmbMaLopTK.SelectedIndex != -1)
			{
				sql += @"From SinhVien join Thuephong on SinhVien.Masinhvien = Thuephong.Masv
									   join Phong on Thuephong.Maphong = Phong.Maphong";
				dk += @" SinhVien.Malop like N'%" + cmbMaLopTK.Text + @"%'";
				dk += @" AND Phong.Maphong like N'%" + cmbMaPhongTK.Text + @"%'";
			}
			//Tim kiem theo Maphong khi Malop la rong
			if (cmbMaPhongTK.SelectedIndex != -1 && cmbMaLopTK.SelectedIndex == -1)
			{
				sql += @"From SinhVien join Thuephong on SinhVien.Masinhvien = Thuephong.Masv
									   join Phong on Thuephong.Maphong = Phong.Maphong";
				dk += @" Phong.Maphong like N'%" + cmbMaPhongTK.Text + @"%'";
			}
			//Ket hoi dk
			if (dk != "")
			{
				sql += @" WHERE" + dk;
			}
			//Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
			
			if (pd.DocBang(sql).Rows.Count == 0)
			{
				dgvDSSinhVien.DataSource = pd.DocBang(sql);
				MessageBox.Show("Không tìm thấy sinh viên nào!!!");
			}
			else dgvDSSinhVien.DataSource = pd.DocBang(sql);
			errLoi.Clear();
			cmbMaKhoaTK.Text = "";
			cmbMaLopTK.Text = "";
			cmbGioiTinhTK.Text = "";
			cmbMaPhongTK.Text = "";
			cmbMaKhoaTK.SelectedIndex = -1;
			cmbMaLopTK.SelectedIndex = -1;
			cmbGioiTinhTK.SelectedIndex = -1;
			cmbMaPhongTK.SelectedIndex = -1;
			cmbMaLopTK.Enabled = false;
			cmbMaPhongTK.Enabled = false;
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
