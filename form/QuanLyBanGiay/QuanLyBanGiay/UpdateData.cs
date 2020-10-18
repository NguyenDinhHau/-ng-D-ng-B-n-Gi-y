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
    public partial class frm_update : Form
    {
        int stt_data = 0;
        public frm_update(int stt)
        {
            InitializeComponent();
            stt_data = stt;
        }
        string file_data = @"D:\c#\form\QuanLyBanGiay\HangGiay.txt";
        string hinh_1 = null;
        string hinh_2 = null;
        string hinh_3 = null;
        SqlConnection conn = null;
        string strSql = "Server = DESKTOP-KJ1U6CT;Database = CSDL_QLBG; user id = sa; pwd = Hoa95@100";
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
        private void frm_update_Load(object sender, EventArgs e)
        {
            string[] data = System.IO.File.ReadAllLines(file_data);
            for (int i = 0; i < data.Length; i++)
            {
                cmb_ud_hangGiay.Items.Add(data[i]);
            }
            connect_data();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DataGiay where Stt = @stt";
            command.Connection = conn;
            SqlParameter parma = new SqlParameter("@stt", SqlDbType.Int);
            parma.Value = stt_data+"";
            command.Parameters.Add(parma);

            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                cmb_ud_hangGiay.Text = reader.GetString(1);
                txt_ud_tenGiay.Text = reader.GetString(2);
                txt_ud_mauGiay.Text = reader.GetString(10);
                txt_ud_size.Text = reader.GetString(3);
                txt_ud_loaiGiay.Text = reader.GetString(4);
                txt_ud_viTri.Text = reader.GetString(5);
                txt_ud_giaBan.Text = reader.GetString(6);
                ud_img_1.Image = Image.FromFile(reader.GetString(7));
                ud_img_2.Image = Image.FromFile(reader.GetString(8));
                ud_img_3.Image = Image.FromFile(reader.GetString(9));
                hinh_1 = reader.GetString(7);
                hinh_2 = reader.GetString(8);
                hinh_3 = reader.GetString(9);
            }
            conn.Close();
        }

        private void ud_btn_hinh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_1 = fileDialog.FileName;
                ud_img_1.Image = Image.FromFile(hinh_1);
            }
        }

        private void ud_btn_hinh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_2 = fileDialog.FileName;
                ud_img_2.Image = Image.FromFile(hinh_2);
            }
        }

        private void ud_btn_hinh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_3 = fileDialog.FileName;
                ud_img_3.Image = Image.FromFile(hinh_3);
            }
        }

        private void ud_btn_luuDuLieu_Click(object sender, EventArgs e)
        {
            connect_data();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            string sql_str = "Update DataGiay set HangGiay = N'" + cmb_ud_hangGiay.Text +"',Model = N'"+ txt_ud_tenGiay.Text+ "', GhiChu = N'"+ txt_ud_loaiGiay.Text+"',MauGiay = N'"+txt_ud_mauGiay.Text+"',Size = N'"+txt_ud_size.Text+"',GiaBan = N'"+txt_ud_giaBan.Text+"',Hinh1 = N'"+ hinh_1 + "',Hinh2 = N'" + hinh_2 + "',Hinh3 = N'" + hinh_3 + "' where Stt = @stt";
            command.CommandText = sql_str;
            command.Connection = conn;

            SqlParameter parma = new SqlParameter("@stt", SqlDbType.Int);
            parma.Value = stt_data + "";
            command.Parameters.Add(parma);

            int ret = command.ExecuteNonQuery();
            if(ret > 0)
            {
                MessageBox.Show("Update Thanh Cong");
            } 
            else
            {
                MessageBox.Show("Update Thanh Cong");
            }
            conn.Close();
            Close();
        }

        private void ud_btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
