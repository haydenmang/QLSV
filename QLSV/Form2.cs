using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_2 : Form
    {
        // 1. Chỗ khai báo biến (giữ nguyên của bạn)
        string maSV_Logged = "";
        string strCon = @"Data Source=DESKTOP-D6NS05N;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";

        public frm_2(string maSV)
        {
            InitializeComponent();
            maSV_Logged = maSV;
        }

        private void frm_2_Load(object sender, EventArgs e)
        {
            LoadThongTinSinhVien(); // Hết lỗi sau khi dán hàm ở dưới
            SetGridViewStyle();
        }

        void SetGridViewStyle()
        {
            if (dgv_SinhVien.Columns.Count > 0)
            {
                dgv_SinhVien.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
                dgv_SinhVien.Columns["HoSV"].HeaderText = "Họ";
                dgv_SinhVien.Columns["TenSV"].HeaderText = "Tên";
                // ... các dòng đổi tên khác của bạn
            }
        }

        void LoadThongTinSinhVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    string sql = "SELECT * FROM SinhVien WHERE MaSV = @ma";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ma", maSV_Logged);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgv_SinhVien.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
