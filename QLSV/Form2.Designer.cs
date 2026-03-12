namespace QLSV
{
    partial class frm_2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.SuspendLayout();

            // Cấu hình nâng cao cho DataGridView
            this.dgv_SinhVien.AllowUserToAddRows = false; // Không hiện dòng trống dưới cùng
            this.dgv_SinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Màu xen kẽ cho các dòng để dễ đọc
            this.dgv_SinhVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 239, 249);

            this.dgv_SinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SinhVien.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            this.dgv_SinhVien.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;

            this.dgv_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SinhVien.EnableHeadersVisualStyles = false; // Để tự chỉnh màu Header
            this.dgv_SinhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 25, 72);
            this.dgv_SinhVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            this.dgv_SinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.ReadOnly = true; // Chỉ cho xem, không cho sửa trực tiếp trên bảng
            this.dgv_SinhVien.Size = new System.Drawing.Size(900, 500);
            this.dgv_SinhVien.TabIndex = 0;

            // Form settings
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgv_SinhVien);
            this.Name = "frm_2";
            this.Text = "HỒ SƠ SINH VIÊN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.DataGridView dgv_SinhVien;
    }
}