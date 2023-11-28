using ConnectDB;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
	public partial class FormDSHD : Form
	{
		ProcessDataBase pd = new ProcessDataBase();

		string temp;
		public FormDSHD(string query)
		{
			InitializeComponent();

			temp = query;
		}

		private void FormDSHD_Load(object sender, EventArgs e)
		{
			dgvThuePhong.DataSource = pd.DocBang(temp);
			dgvThuePhong.AutoGenerateColumns = true;
		}

		private void btn_XuatExcel_Click(object sender, EventArgs e)
		{

			if (temp.ToLower() == "select * from thuephong")
			{
				using (var package = new ExcelPackage())
				{
					var worksheet = package.Workbook.Worksheets.Add("Danh sách Hóa đơn");
					worksheet.Cells["A1:F1"].Merge = true;
					worksheet.Cells["A1"].Value = "Danh sách Hóa đơn";
					worksheet.Cells["A1"].Style.Font.Size = 16;
					worksheet.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

					worksheet.Cells["A2"].Value = "Mã số thuê";
					worksheet.Cells["B2"].Value = "Mã sinh viên";
					worksheet.Cells["C2"].Value = "Mã phòng";
					worksheet.Cells["D2"].Value = "Ngày bắt đầu";
					worksheet.Cells["E2"].Value = "Ngày kết thúc";
					worksheet.Cells["F2"].Value = "Ghi chú";
					worksheet.Cells["A2:F2"].Style.Font.Size = 14;
					worksheet.Cells["A2:F2"].Style.Font.Bold = true;

					for (int i = 0; i < dgvThuePhong.Rows.Count - 1; i++)
					{
						worksheet.Cells[3 + i, 1].Value = (i + 1).ToString();
						worksheet.Cells[3 + i, 2].Value = dgvThuePhong.Rows[i].Cells[0].Value.ToString();
						worksheet.Cells[3 + i, 3].Value = dgvThuePhong.Rows[i].Cells[1].Value.ToString();
						worksheet.Cells[3 + i, 4].Value = dgvThuePhong.Rows[i].Cells[2].Value.ToString();
						worksheet.Cells[3 + i, 5].Value = dgvThuePhong.Rows[i].Cells[3].Value.ToString();
						worksheet.Cells[3 + i, 6].Value = dgvThuePhong.Rows[i].Cells[4].Value.ToString();
						worksheet.Cells[3 + i, 6].Value = dgvThuePhong.Rows[i].Cells[5].Value.ToString();
					}

					SaveFileDialog svf = new SaveFileDialog();
					svf.Title = "Chọn đường dẫn và đặt tên tệp lưu dữ liệu";
					svf.Filter = "Excel Files|*.xlsx";
					svf.ShowDialog();
					string filename = svf.FileName;
					if (filename == "")
					{
						MessageBox.Show("Bạn chưa đặt tên file");
					}
					else
					{
						File.WriteAllBytes(filename, package.GetAsByteArray());
						MessageBox.Show("Lưu thành công.");
					}
				}
			}
			else
			{
				using (var package = new ExcelPackage())
				{
					var worksheet = package.Workbook.Worksheets.Add("Thu tiền phòng");
					worksheet.Cells["A1:K1"].Merge = true;
					worksheet.Cells["A1"].Value = "Thu tiền phòng";
					worksheet.Cells["A1"].Style.Font.Size = 16;
					worksheet.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

					worksheet.Cells["A2"].Value = "Mã phòng";
					worksheet.Cells["B2"].Value = "Tháng";
					worksheet.Cells["C2"].Value = "Năm";
					worksheet.Cells["D2"].Value = "Tiền nhà";
					worksheet.Cells["E2"].Value = "Tiền điện";
					worksheet.Cells["F2"].Value = "Tiền nước";
					worksheet.Cells["G2"].Value = "Tiền vệ sinh";
					worksheet.Cells["H2"].Value = "Tiền phạt";
					worksheet.Cells["I2"].Value = "Ngày hết hạn";
					worksheet.Cells["J2"].Value = "Ngày đóng";
					worksheet.Cells["K2"].Value = "Tổng tiền";
					worksheet.Cells["A2:K2"].Style.Font.Size = 14;
					worksheet.Cells["A2:K2"].Style.Font.Bold = true;

					for (int i = 0; i < dgvThuePhong.Rows.Count - 1; i++)
					{
						worksheet.Cells[3 + i, 1].Value = (i + 1).ToString();
						worksheet.Cells[3 + i, 2].Value = dgvThuePhong.Rows[i].Cells[0].Value.ToString();
						worksheet.Cells[3 + i, 3].Value = dgvThuePhong.Rows[i].Cells[1].Value.ToString();
						worksheet.Cells[3 + i, 4].Value = dgvThuePhong.Rows[i].Cells[2].Value.ToString();
						worksheet.Cells[3 + i, 5].Value = dgvThuePhong.Rows[i].Cells[3].Value.ToString();
						worksheet.Cells[3 + i, 6].Value = dgvThuePhong.Rows[i].Cells[4].Value.ToString();
						worksheet.Cells[3 + i, 7].Value = dgvThuePhong.Rows[i].Cells[5].Value.ToString();
						worksheet.Cells[3 + i, 8].Value = dgvThuePhong.Rows[i].Cells[6].Value.ToString();
						worksheet.Cells[3 + i, 9].Value = dgvThuePhong.Rows[i].Cells[7].Value.ToString();
						worksheet.Cells[3 + i, 10].Value = dgvThuePhong.Rows[i].Cells[8].Value.ToString();
						worksheet.Cells[3 + i, 11].Value = dgvThuePhong.Rows[i].Cells[9].Value.ToString();
						worksheet.Cells[3 + i, 12].Value = dgvThuePhong.Rows[i].Cells[10].Value.ToString();
					}

					SaveFileDialog svf = new SaveFileDialog();
					svf.Title = "Chọn đường dẫn và đặt tên tệp lưu dữ liệu";
					svf.Filter = "Excel Files|*.xlsx";
					svf.ShowDialog();
					string filename = svf.FileName;
					if (filename == "")
					{
						MessageBox.Show("Bạn chưa đặt tên file");
					}
					else
					{
						File.WriteAllBytes(filename, package.GetAsByteArray());
						MessageBox.Show("Lưu thành công.");
					}
				}
			}
		}
	}
}
