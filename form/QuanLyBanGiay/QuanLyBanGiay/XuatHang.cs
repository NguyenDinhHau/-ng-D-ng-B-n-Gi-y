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

namespace QuanLyBanGiay
{
    public partial class frm_xuatHang : Form
    {
        SqlConnection conn = null;
        string strSql = "Server = DESKTOP-KJ1U6CT;Database = CSDL_QLBG; user id = sa; pwd = Hoa95@100";
        int stt_data = 0;
        public frm_xuatHang(int stt)
        {
            stt_data = stt;
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frm_xuatHang_Load(object sender, EventArgs e)
        {
            connect_data();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DataGiay where Stt = @stt";
            command.Connection = conn;
            SqlParameter parma = new SqlParameter("@stt", SqlDbType.Int);
            parma.Value = stt_data + "";
            command.Parameters.Add(parma);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lbl_hangGiay.Text = reader.GetString(1);
                lbl_model.Text = reader.GetString(2);
                lbl_mauGiay.Text = reader.GetString(10);
                lbl_size.Text = reader.GetString(3);
                lbl_ghiChu.Text = reader.GetString(4);
                lbl_viTri.Text = reader.GetString(5);
                lbl_giaBan.Text = reader.GetString(6);
                pic_1.Image = Image.FromFile(reader.GetString(7));
                pic_2.Image = Image.FromFile(reader.GetString(8));
                pic_3.Image = Image.FromFile(reader.GetString(9));
            }
            conn.Close();
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

        private void xh_btn_xuatHang_Click(object sender, EventArgs e)
        {
            if (txt_nguoiBan.Text == "")
            {
                errorProvider1.SetError(xh_btn_xuatHang, "Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                connect_data();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                string sql_insert = "Insert into XuatHang(HangGiay,Model,MauGiay,Size,GhiChu,ViTri,GiaBan,NgayBan,NguoiBan)" +
                    "values (N'" + lbl_hangGiay.Text + "',N'" + lbl_model.Text + "',N'" + lbl_mauGiay.Text + "',N'" + lbl_size.Text + "',N'" + lbl_ghiChu.Text + "',N'" + lbl_viTri.Text + "',N'" + lbl_giaBan.Text + "',N'" + dtp_time.Value + "',N'" + txt_nguoiBan.Text + "')";
                sqlCommand.CommandText = sql_insert;
                sqlCommand.Connection = conn;

                int ret = sqlCommand.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Ban đã xuất hàng");
                }
                else
                {
                    MessageBox.Show("Không Thể Xuất Hàng");
                }
                conn.Close();

                connect_data();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql_str = "delete from DataGiay where Stt = " + stt_data;
                command.CommandText = sql_str;
                command.Connection = conn;

                int ret_xoa = command.ExecuteNonQuery();

                if (ret_xoa > 0)
                {

                }
                else
                {
                    MessageBox.Show("Lỗi Xóa Data Nhập");
                }
                conn.Close();
                Close();



            }
        }

        private void xh_btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
