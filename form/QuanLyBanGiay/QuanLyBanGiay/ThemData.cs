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
    public partial class frm_them_data : Form
    {
        int stt = 0;
        string hinh_1 = null;
        string hinh_2 = null;
        string hinh_3 = null;
        public frm_them_data()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        string file_data = @"D:\c#\form\QuanLyBanGiay\HangGiay.txt";
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
        private void frm_them_data_Load(object sender, EventArgs e)
        {
            connect_data();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from DataGiay";
            command.Connection = conn;
            object v = command.ExecuteScalar();
            stt = (int)v;
            conn.Close();
            string[] data = System.IO.File.ReadAllLines(file_data);
            for(int i = 0; i< data.Length;i++)
            {
                cmb_hangGiay.Items.Add(data[i]);
            }    
        }

        private void btn_hinh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_1 = fileDialog.FileName;
                img_1.Image = Image.FromFile(hinh_1);
            }
        }

        private void btn_hinh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_2 = fileDialog.FileName;
                img_2.Image = Image.FromFile(hinh_2);
            }
        }

        private void btn_hinh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                hinh_3 = fileDialog.FileName;
                img_3.Image = Image.FromFile(hinh_3);
            }
        }

        private void btn_luuDuLieu_Click(object sender, EventArgs e)
        {
            if(txt_tenGiay.Text == "" || txt_mauGiay.Text == "" ||txt_loaiGiay.Text == ""||txt_size.Text == "" || txt_giaBan.Text == "")
            {
                errorProvider1.SetError(btn_luuDuLieu, "Bạn cần nhập đầy đủ thông tin");
            }    
            else
            {
                connect_data();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                string sql_insert = "Insert into DataGiay(HangGiay,Model,MauGiay,Size,GhiChu,ViTri,GiaBan,Hinh1,Hinh2,Hinh3)" +
                    "values (N'" + cmb_hangGiay.Text + "',N'" + txt_tenGiay.Text + "',N'" + txt_mauGiay.Text + "',N'" + txt_size.Text + "',N'" + txt_loaiGiay.Text + "',N'" + txt_viTri.Text + "',N'" + txt_giaBan.Text + "',N'" + hinh_1 + "',N'" + hinh_2 + "',N'" + hinh_3 + "')";
                sqlCommand.CommandText = sql_insert;
                sqlCommand.Connection = conn;

                int ret = sqlCommand.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Ban đã lưu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                conn.Close();
                Close();

            }

        }

    }
}
