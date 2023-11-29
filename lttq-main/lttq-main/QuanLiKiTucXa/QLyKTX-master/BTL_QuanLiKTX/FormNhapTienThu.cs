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
	public partial class FormNhapTienThu : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormNhapTienThu()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FormNhapTienThu_Load(object sender, EventArgs e)
		{
			string query1 = "select Maphong from Phong";
			DataTable dataTable = pd.DocBang(query1);

			if (dataTable != null)
			{
				foreach (DataRow row in dataTable.Rows)
				{
					string key = row["Maphong"].ToString();

					ToolStripMenuItem menuItem = new ToolStripMenuItem($"{key}");
					menuItem.Tag = key;

					cmb_MaPhong.Items.Add(menuItem);
				}
			}

			cmb_Thang.Items.Add("1");
			cmb_Thang.Items.Add("2");
			cmb_Thang.Items.Add("3");
			cmb_Thang.Items.Add("4");
			cmb_Thang.Items.Add("5");
			cmb_Thang.Items.Add("6");
			cmb_Thang.Items.Add("7");
			cmb_Thang.Items.Add("8");
			cmb_Thang.Items.Add("9");
			cmb_Thang.Items.Add("10");
			cmb_Thang.Items.Add("11");
			cmb_Thang.Items.Add("12");

			cmb_Nam.Items.Add("2023");
			cmb_Nam.Items.Add("2024");
			cmb_Nam.Items.Add("2025");
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			string query = "";
			pd.KetNoi();

			if (cmb_MaPhong.SelectedIndex == -1) {errorLoi.SetError(cmb_MaPhong, "Bạn không được để trống mã phòng!"); return;} else { errorLoi.Clear();}
			if (cmb_Thang.SelectedIndex == -1) { errorLoi.SetError(cmb_Thang, "Bạn không được để trống tháng!"); return; } else { errorLoi.Clear(); }
			if (cmb_Nam.SelectedIndex == -1) { errorLoi.SetError(cmb_Nam, "Bạn không được để trống năm!"); return; } else { errorLoi.Clear(); }

			if (txt_Tiendien.Text.Trim() == "") { errorLoi.SetError(txt_Tiendien, "Bạn không được để trống!"); return; } else { errorLoi.Clear(); }
			if (txt_Tiennha.Text.Trim() == "") { errorLoi.SetError(txt_Tiennha, "Bạn không được để trống!"); return; } else { errorLoi.Clear(); }
			if (txt_Tiennuoc.Text.Trim() == "") { errorLoi.SetError(txt_Tiennuoc, "Bạn không được để trống!"); return; } else { errorLoi.Clear(); }
			if (txt_Tienvesinh.Text.Trim() == "") { errorLoi.SetError(txt_Tienvesinh, "Bạn không được để trống!"); return; } else { errorLoi.Clear(); }

			string checkQuery = $"SELECT COUNT(*) FROM Thutienphong WHERE Maphong = '{cmb_MaPhong.Text}' AND Thang = N'{cmb_Thang.Text}' AND Nam = '{cmb_Nam.Text}'";

			DataTable count = pd.DocBang(checkQuery);
			if(count.Rows.Count > 0)
			{
				MessageBox.Show("Mã phòng đã tồn tại tiền thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else
			{
				query = "insert into Thutienphong(Maphong, Thang, Nam, Tiennha, Tiendien, Tiennuoc, Tienvesinh, Tienphat, Ngayhethan, Ngaydong) values";
				query += "('" + cmb_MaPhong.Text + "'" +
					",N'" + cmb_Thang.Text + "'" +
					",'" + cmb_Nam.Text + "'" +
					",'" + txt_Tiennha.Text + "'" +
					",'" + txt_Tiendien.Text + "'" +
					",'" + txt_Tiennuoc.Text + "'" +
					",'" + txt_Tienvesinh.Text + "'" +
					",'" + txt_Tienphat.Text + "'" +
					",'" + dtp_Ngayhethan.Value.ToString("yyyy-MM-dd") + "'" +
					",'" + dtp_Ngaydong.Value.ToString("yyyy-MM-dd") + "')";

				pd.CapNhat(query);
			}
		}

		private void txt_Tienphat_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtp_Ngaydong_ValueChanged(object sender, EventArgs e)
		{
			setTienPhat();

		}

		private void dtp_Ngayhethan_ValueChanged(object sender, EventArgs e)
		{
			setTienPhat();
		}

		private int TinhTienPhat()
		{
			DateTime Ngaydong = dtp_Ngaydong.Value;
			DateTime Ngayhethan = dtp_Ngayhethan.Value;
			int TienPhat;

			if(Ngaydong.Date <= Ngayhethan.Date)
			{
				TienPhat = 0;
			} else
			{
				double Late = (Ngaydong - Ngayhethan).TotalDays;
				TienPhat = (int)(10000 * Late)+1;
			}

			return TienPhat;
		}

		private void setTienPhat()
		{
			int TienPhat = TinhTienPhat();

			txt_Tienphat.Text = TienPhat.ToString();
			txt_Tienphat.Enabled = false;
		}

		private void btn_Huy_Click(object sender, EventArgs e)
		{
				this.Close();
		}
	}
}
