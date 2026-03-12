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
    public partial class frm_admin : Form
    {
            string strCon = @"Data Source=DESKTOP-D6NS05N;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";

        public frm_admin()
        {
            InitializeComponent();
        }

        private void dgv_Admin_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dgv_Admin_SinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}