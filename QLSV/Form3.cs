using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_admin : Form
    {
        string strCon = @"Data Source=DESKTOP-D6NS05N;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";

        public frm_admin()
        {
            InitializeComponent();
        }

        private void frm_admin_load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadSinhVien();
        }

        void LoadKhoa()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaKH FROM Khoa", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmb_Lop.DataSource = dt;
                    cmb_Lop.DisplayMember = "MaKH";
                    cmb_Lop.ValueMember = "MaKH";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khoa: " + ex.Message);
            }
        }

        void LoadSinhVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_Admin_SinhVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgv_Admin_SinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Admin_SinhVien.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgv_Admin_SinhVien.SelectedRows[0];
            txt_MaSV.Text = row.Cells["MaSV"].Value?.ToString() ?? "";
            txt_HoTen.Text = (row.Cells["HoSV"].Value?.ToString() ?? "") + " " + (row.Cells["TenSV"].Value?.ToString() ?? "");
            chk_Phai.Checked = row.Cells["Phai"].Value != null && (bool)row.Cells["Phai"].Value;
            txt_NoiSinh.Text = row.Cells["NoiSinh"].Value?.ToString() ?? "";
            cmb_Lop.SelectedValue = row.Cells["MaKH"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
                dtp_NgaySinh.Value = ngaySinh;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maSV = txt_MaSV.Text.Trim();
            string hoTen = txt_HoTen.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên.");
                return;
            }
            if (maSV.Length > 3) { MessageBox.Show("Mã SV tối đa 3 ký tự."); return; }

            int lastSpace = hoTen.LastIndexOf(' ');
            string ho = lastSpace >= 0 ? hoTen.Substring(0, lastSpace) : hoTen;
            string ten = lastSpace >= 0 ? hoTen.Substring(lastSpace + 1) : "";

            if (ho.Length > 15) { MessageBox.Show("Họ tối đa 15 ký tự."); return; }
            if (ten.Length > 7) { MessageBox.Show("Tên tối đa 7 ký tự."); return; }

            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    string sql = "INSERT INTO SinhVien (MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSinh, MaKH) VALUES (@MaSV, @HoSV, @TenSV, @Phai, @NgaySinh, @NoiSinh, @MaKH)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@HoSV", ho);
                    cmd.Parameters.AddWithValue("@TenSV", ten);
                    cmd.Parameters.AddWithValue("@Phai", chk_Phai.Checked);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtp_NgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@NoiSinh", txt_NoiSinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaKH", cmb_Lop.SelectedValue?.ToString() ?? "");
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm sinh viên thành công!");
                LoadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
