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
	public partial class FormQLHoaDon : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		FormDSHD dshd = new FormDSHD("");
		public FormQLHoaDon()
		{
			InitializeComponent();
		}

		private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void FormQLHoaDon_Load(object sender, EventArgs e)
		{
			loadFunction(new FormDSHD("select * from ThuePhong"));

			try
			{
				thuTiềnPhòngToolStripMenuItem.DropDownItems.Clear();


				string query1 = "select Maphong from Phong";
				DataTable dataTable = pd.DocBang(query1);

				if (dataTable != null)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						string key = row["Maphong"].ToString();

						ToolStripMenuItem menuItem = new ToolStripMenuItem($"{key}");
						menuItem.Tag = key;

						menuItem.Click += MenuItem_Click;

						thuTiềnPhòngToolStripMenuItem.DropDownItems.Add(menuItem);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "Error");
			}
		}

		private void MenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
			string id = (string)clickedItem.Tag;

			string query = "SELECT Thutienphong.*, " +
				   "((Phong.Songuoitoida * Phong.Songuoidango) + " +
				   "(Thutienphong.Tiennha + Thutienphong.Tiendien + Thutienphong.Tiennuoc + " +
				   "Thutienphong.Tienvesinh + Thutienphong.Tienphat)) AS Tongtien " +
				   "FROM Thutienphong JOIN Phong ON Thutienphong.Maphong = Phong.Maphong " +
				   "WHERE Thutienphong.Maphong = '" + id + "'";

			loadFunction(new FormDSHD(query));
		}


		private void tìmKiếmHóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			loadFunction(new FormTKHoaDon());
		}

		public void loadFunction(object Form)
		{
			if (this.loadPanel.Controls.Count > 0)
				this.loadPanel.Controls.RemoveAt(0);

			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.loadPanel.Controls.Add(f);
			this.loadPanel.Tag = f;
			f.Show();
		}

		private void thuTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void dgvThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
		{
			if (this.loadPanel.Controls.Count == 0) loadFunction(new FormDSHD("select * from ThuePhong"));
		}
	}
}
