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
	public partial class FormTrangChu : Form
	{
		public FormTrangChu()
		{
			InitializeComponent();
		}

		public void loadFunction(object Form)
		{
			if (this.loadContent.Controls.Count > 0)
				this.loadContent.Controls.RemoveAt(0);

			Form f = Form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.loadContent.Controls.Add(f);
			this.loadContent.Tag = f;
			f.Show();
		}

		private void btnQuanLiSV_Click(object sender, EventArgs e)
		{
			panel1.Hide();
			loadFunction(new FormMainQLSV());
		}

		private void btnQuanLiHoaDon_Click(object sender, EventArgs e)
		{
			panel1.Hide();
			loadFunction(new FormQLHoaDon());
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
