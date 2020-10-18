using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace QuanLyBanGiay
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strSql = "Server = DESKTOP-KJ1U6CT;Database = CSDL_QLBG; user id = sa; pwd = Hoa95@100";
        public void hienThi()
        {
            connect_data();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from DataGiay";
            sqlCommand.Connection = conn;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            lsv_data.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0) + "");
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(10));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                lsv_data.Items.Add(item);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public void connect_data()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strSql);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_them_data fm_data = new frm_them_data();
            fm_data.ShowDialog(this);
        }

        private void btn_tiemKiem_Click(object sender, EventArgs e)
        {
            fm_timKiem fm_TimKiem = new fm_timKiem();
            fm_TimKiem.ShowDialog(this);
        }

        private void lsv_data_DoubleClick(object sender, EventArgs e)
        {
            if(lsv_data.SelectedItems.Count >0)
            {
                ListViewItem item = lsv_data.SelectedItems[0];
                int stt = int.Parse(item.SubItems[0].Text);
                frm_update frm_update = new frm_update(stt);
                frm_update.ShowDialog(this);
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(lsv_data.SelectedItems.Count >0)
            {
                ListViewItem item = lsv_data.SelectedItems[0];
                int index = int.Parse(item.SubItems[0].Text);
                connect_data();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql_str = "delete from DataGiay where Stt = " + index;
                command.CommandText = sql_str;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();

                if(ret > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }    
                else
                {
                    MessageBox.Show("Lỗi Xóa");
                }
                conn.Close();
            } 
            else
            {
                MessageBox.Show("Bạn cần chọn item để xóa");
            }    
        }

        private void frm_main_Click(object sender, EventArgs e)
        {
            hienThi();
        }

        private void btn_xuatFile_Click(object sender, EventArgs e)
        {
            // khoi tao excel 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // Khỏi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Khoi tao WorkSheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Worksheets[1];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;


            Range row1_tieuDe = worksheet.get_Range("B2", "I2");
            row1_tieuDe.Merge();
            row1_tieuDe.Value2 = "Dữ liệu giầy";
            row1_tieuDe.Font.Size = 10;
            row1_tieuDe.Cells.Interior.Color = Color.Yellow;
            row1_tieuDe.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row1_tieuDe.Borders.Color = System.Drawing.Color.Black.ToArgb();

            // Do dư lieu vao Sheet 
            Range row_stt = worksheet.get_Range("B3", "B3");
            row_stt.Merge();
            row_stt.Value2 = "STT";
            row_stt.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_stt.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_hangGiay = worksheet.get_Range("C3", "C3");
            row_hangGiay.Merge();
            row_hangGiay.Value2 = "Hãng Giày";
            row_hangGiay.EntireColumn.ColumnWidth = 18;
            row_hangGiay.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_hangGiay.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_tenGiay = worksheet.get_Range("D3", "D3");
            row_tenGiay.Merge();
            row_tenGiay.Value2 = "Tên Giày";
            row_tenGiay.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_tenGiay.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_mauGiay = worksheet.get_Range("E3", "E3");
            row_mauGiay.Merge();
            row_mauGiay.Value2 = "Màu Giầy";
            row_mauGiay.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_mauGiay.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_size = worksheet.get_Range("F3", "F3");
            row_size.Merge();
            row_size.Value2 = "Size";
            row_size.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_size.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_loaiGiay = worksheet.get_Range("G3", "G3");
            row_loaiGiay.Merge();
            row_loaiGiay.Value2 = "Ghi Chú";
            row_loaiGiay.EntireColumn.ColumnWidth = 30;
            row_loaiGiay.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_loaiGiay.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_viTri = worksheet.get_Range("H3", "H3");
            row_viTri.Merge();
            row_viTri.Value2 = "Vị Trí";
            row_viTri.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_viTri.Borders.Color = System.Drawing.Color.Black.ToArgb();

            Range row_giaBan = worksheet.get_Range("I3", "I3");
            row_giaBan.Merge();
            row_giaBan.Value2 = "Gía Bán";
            row_giaBan.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row_giaBan.EntireColumn.ColumnWidth = 18;
            row_giaBan.Borders.Color = System.Drawing.Color.Black.ToArgb();

            for (int row = 0; row < lsv_data.Items.Count; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    worksheet.Cells[4 + row, 2 + col] = lsv_data.Items[row].SubItems[col].Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsv_data.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_data.SelectedItems[0];
                int stt = int.Parse(item.SubItems[0].Text);
                frm_xuatHang frm_xuatHang = new frm_xuatHang(stt);
                frm_xuatHang.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_dsXuat ds_xuat = new frm_dsXuat();
            ds_xuat.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienThi();
        }
    }
}
