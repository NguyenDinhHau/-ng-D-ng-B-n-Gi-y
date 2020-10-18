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
    public partial class fm_timKiem : Form
    {
        public fm_timKiem()
        {
            InitializeComponent();
        }
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
        private void txt_tk_timKiem_Click(object sender, EventArgs e)
        {
            if(txt_tk_size.Text == "")
            {
                errorProvider1.SetError(txt_tk_size, "Bạn cần nhập Size giày muốn tiềm kiếm");
            }
            else
            {
                connect_data();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from DataGiay where Size = @size";
                command.Connection = conn;
                SqlParameter parma = new SqlParameter("@size", SqlDbType.Int);
                parma.Value = txt_tk_size.Text;
                command.Parameters.Add(parma);

                SqlDataReader reader = command.ExecuteReader();
                lsv_tiemKiem.Items.Clear();
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
                    lsv_tiemKiem.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void fm_timKiem_Load(object sender, EventArgs e)
        {

        }

        private void lsv_tiemKiem_DoubleClick(object sender, EventArgs e)
        {
            if (lsv_tiemKiem.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_tiemKiem.SelectedItems[0];
                int stt = int.Parse(item.SubItems[0].Text);
                frm_update frm_update = new frm_update(stt);
                frm_update.ShowDialog(this);
            }
        }

        private void txt_tk_xoa_Click(object sender, EventArgs e)
        {
            if (lsv_tiemKiem.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_tiemKiem.SelectedItems[0];
                int index = int.Parse(item.SubItems[0].Text);
                connect_data();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql_str = "delete from DataGiay where Stt = " + index;
                command.CommandText = sql_str;
                command.Connection = conn;

                int ret = command.ExecuteNonQuery();

                if (ret > 0)
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsv_tiemKiem.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_tiemKiem.SelectedItems[0];
                int stt = int.Parse(item.SubItems[0].Text);
                frm_xuatHang frm_xuatHang = new frm_xuatHang(stt);
                frm_xuatHang.ShowDialog(this);
            }
        }
    }
}
