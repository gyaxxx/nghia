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
//using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_QuanLiKTX
{
	public partial class FormMainQLSV : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public FormMainQLSV()
		{
			InitializeComponent();
		}	

		private void FormMainQLSV_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dbQLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

			string query = "Select * from SinhVien";
			dgvDSSinhVien.DataSource = pd.DocBang(query);
		}

		private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormThemSinhVien them = new FormThemSinhVien();
			them.ShowDialog();
			this.Close();
		}

		private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			/* if (MessageBox.Show("Bạn có muốn xuất file excel danh sách sinh viên không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook =
				exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet exSheet =
					(Excel.Worksheet)exBook.Worksheets[1];
				Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
				tenvung.Font.Name = "Arial"; tenvung.Font.Size = 16;
				tenvung.Font.Color = Color.Blue;
				tenvung.Value = "Danh sách sinh viên";
				exSheet.get_Range("A1: H1").Merge(true);
				exSheet.get_Range("A2:H2").Font.Size = 15;
				exSheet.get_Range("A2:H2").ColumnWidth = 16;
				exSheet.get_Range("D2").ColumnWidth = 20;
				exSheet.get_Range("A2:H2").Font.Bold = true;
				exSheet.get_Range("A:H").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				exSheet.get_Range("A2").Value = "STT";
				exSheet.get_Range("B2").Value = "Mã sinh viên";
				exSheet.get_Range("C2").Value = "Tên sinh viên";
				exSheet.get_Range("D2").Value = "Ngày sinh";
				exSheet.get_Range("E2").Value = "Giới tính";
				exSheet.get_Range("F2").Value = "Mã quê";
				exSheet.get_Range("G2").Value = "Mã khoa";
				exSheet.get_Range("H2").Value = "Mã lớp";
				int k = dgvDSSinhVien.Rows.Count - 1;
				exSheet.get_Range("A2:H" + (k + 2).ToString()).
					Borders.LineStyle
					= Excel.XlLineStyle.xlDouble;//.Borders( true);
				for (int i = 0; i < dgvDSSinhVien.Rows.Count - 1; i++)
				{
					exSheet.get_Range("A" + (3 + i).ToString()).Value =
						(i + 1).ToString();
					exSheet.get_Range("B" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[0].Value.ToString();
					exSheet.get_Range("C" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[1].Value.ToString();
					exSheet.get_Range("D" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[2].Value.ToString();
					exSheet.get_Range("E" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[3].Value.ToString();
					exSheet.get_Range("F" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[4].Value.ToString();
					exSheet.get_Range("G" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[5].Value.ToString();
					exSheet.get_Range("H" + (3 + i).ToString()).Value =
						dgvDSSinhVien.Rows[i].Cells[6].Value.ToString();
				}
				exBook.Activate();
				SaveFileDialog svf = new SaveFileDialog();
				svf.Title = "Chọn đường dẫn và đặt tên tệp lưu dl ";
				svf.ShowDialog();
				string filename = svf.FileName;
				if (filename == "")
				{
					MessageBox.Show("Bạn chưa đặt tên file");
				}
				exBook.SaveAs(filename);
				exApp.Quit();
			}*/
			
		}

		private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormTimKiem them = new FormTimKiem();
			them.ShowDialog();
			this.Close();
		}

		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormEditSV them = new FormEditSV();
			them.ShowDialog();
			this.Close();
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			dgvDSSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
		}

		private void btnLivingKTX_Click(object sender, EventArgs e)
		{
			string sql = @"Select SinhVien.* 
						   From SinhVien join Thuephong on SinhVien.Masinhvien = Thuephong.Masv
						   Where Thuephong.Ngaykt > Getdate()";
			dgvDSSinhVien.DataSource = pd.DocBang(sql);
		}

		private void dgvDSSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
