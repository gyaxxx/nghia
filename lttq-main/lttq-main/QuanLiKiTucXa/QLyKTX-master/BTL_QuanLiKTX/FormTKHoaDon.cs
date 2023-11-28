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
	public partial class FormTKHoaDon : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormTKHoaDon()
		{
			InitializeComponent();
		}

		private void FormTKHoaDon_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'qLKyTucXaDataSet.Thuephong' table. You can move, or remove it, as needed.
            this.thuephongTableAdapter.Fill(this.qLKyTucXaDataSet.Thuephong);

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txt_mahoadon_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_TimKiem_Click(object sender, EventArgs e)
		{
			if(txt_mahoadon.Text.Trim().Length > 0 && txt_MaPhong.Text.Trim().Length == 0 && txt_MaSinhVien.Text.Trim().Length == 0)
			{
				string query = "select * from ThuePhong where Masothue = '" + txt_mahoadon.Text.Trim() + "'";
				dgvTimThuePhong.DataSource = pd.DocBang(query);
			}

			if (txt_mahoadon.Text.Trim().Length == 0 && txt_MaPhong.Text.Trim().Length > 0 && txt_MaSinhVien.Text.Trim().Length == 0)
			{
				string query = "select * from ThuePhong where Maphong = '" + txt_MaPhong.Text.Trim() + "'";
				dgvTimThuePhong.DataSource = pd.DocBang(query);
			}

			if (txt_mahoadon.Text.Trim().Length == 0 && txt_MaPhong.Text.Trim().Length == 0 && txt_MaSinhVien.Text.Trim().Length > 0)
			{
				string query = "select * from ThuePhong where Masv = '" + txt_MaSinhVien.Text.Trim() + "'";
				dgvTimThuePhong.DataSource = pd.DocBang(query);
			}
		}

		private void dgvTimThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txt_MaPhong_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
