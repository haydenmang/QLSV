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

namespace QLSV
{
    public partial class frm_login : Form
    {
        string strCon = @"Data Source=DESKTOP-D6NS05N;Initial Catalog=QLSINHVIEN;Integrated Security=True";
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string user = txb_1.Text.Trim();
            string pass = txb_2.Text.Trim();

            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!");
                frm_admin fAdmin = new frm_admin();
                fAdmin.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strCon))
                    {
                        conn.Open();
                        string sql = "SELECT COUNT (*) FROM SinhVien WHERE MaSV = @user AND MaKH = @pass";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@user", txb_1.Text);
                        cmd.Parameters.AddWithValue("@pass", txb_2.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            frm_2 f = new frm_2(txb_1.Text);
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai MaSV hoặc MaKH");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối : " + ex.Message);
                }
            }
        }
    }
}
