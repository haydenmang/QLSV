namespace QLSV
{
    partial class frm_admin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.chk_Phai = new System.Windows.Forms.CheckBox();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_NoiSinh = new System.Windows.Forms.Label();
            this.txt_NoiSinh = new System.Windows.Forms.TextBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Admin_SinhVien = new System.Windows.Forms.DataGridView();
            this.pnl_Left.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).BeginInit();
            this.SuspendLayout();

            // pnl_Left
            this.pnl_Left.Controls.Add(this.lbl_Title);
            this.pnl_Left.Controls.Add(this.lbl_MaSV);
            this.pnl_Left.Controls.Add(this.txt_MaSV);
            this.pnl_Left.Controls.Add(this.lbl_HoTen);
            this.pnl_Left.Controls.Add(this.txt_HoTen);
            this.pnl_Left.Controls.Add(this.chk_Phai);
            this.pnl_Left.Controls.Add(this.lbl_NgaySinh);
            this.pnl_Left.Controls.Add(this.dtp_NgaySinh);
            this.pnl_Left.Controls.Add(this.lbl_NoiSinh);
            this.pnl_Left.Controls.Add(this.txt_NoiSinh);
            this.pnl_Left.Controls.Add(this.lbl_Lop);
            this.pnl_Left.Controls.Add(this.cmb_Lop);
            this.pnl_Left.Controls.Add(this.btn_Them);
            this.pnl_Left.Controls.Add(this.btn_Sua);
            this.pnl_Left.Controls.Add(this.btn_Xoa);
            this.pnl_Left.Controls.Add(this.btn_LamMoi);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Size = new System.Drawing.Size(350, 600);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.TabIndex = 1;

            // lbl_Title
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(20, 15);
            this.lbl_Title.Size = new System.Drawing.Size(300, 30);
            this.lbl_Title.Text = "Thông tin sinh viên";

            // lbl_MaSV + txt_MaSV
            this.lbl_MaSV.Location = new System.Drawing.Point(25, 55);
            this.lbl_MaSV.Size = new System.Drawing.Size(100, 20);
            this.lbl_MaSV.Text = "Mã sinh viên:";
            this.txt_MaSV.Location = new System.Drawing.Point(25, 78);
            this.txt_MaSV.Size = new System.Drawing.Size(280, 22);
            this.txt_MaSV.Name = "txt_MaSV";

            // lbl_HoTen + txt_HoTen
            this.lbl_HoTen.Location = new System.Drawing.Point(25, 110);
            this.lbl_HoTen.Size = new System.Drawing.Size(100, 20);
            this.lbl_HoTen.Text = "Họ và tên:";
            this.txt_HoTen.Location = new System.Drawing.Point(25, 133);
            this.txt_HoTen.Size = new System.Drawing.Size(280, 22);
            this.txt_HoTen.Name = "txt_HoTen";

            // chk_Phai
            this.chk_Phai.Location = new System.Drawing.Point(25, 165);
            this.chk_Phai.Size = new System.Drawing.Size(120, 23);
            this.chk_Phai.Text = "Phái nữ";
            this.chk_Phai.Name = "chk_Phai";

            // lbl_NgaySinh + dtp_NgaySinh
            this.lbl_NgaySinh.Location = new System.Drawing.Point(25, 198);
            this.lbl_NgaySinh.Size = new System.Drawing.Size(100, 20);
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            this.dtp_NgaySinh.Location = new System.Drawing.Point(25, 220);
            this.dtp_NgaySinh.Size = new System.Drawing.Size(280, 22);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";

            // lbl_NoiSinh + txt_NoiSinh
            this.lbl_NoiSinh.Location = new System.Drawing.Point(25, 253);
            this.lbl_NoiSinh.Size = new System.Drawing.Size(100, 20);
            this.lbl_NoiSinh.Text = "Nơi sinh:";
            this.txt_NoiSinh.Location = new System.Drawing.Point(25, 275);
            this.txt_NoiSinh.Size = new System.Drawing.Size(280, 22);
            this.txt_NoiSinh.Name = "txt_NoiSinh";

            // lbl_Lop + cmb_Lop
            this.lbl_Lop.Location = new System.Drawing.Point(25, 308);
            this.lbl_Lop.Size = new System.Drawing.Size(100, 20);
            this.lbl_Lop.Text = "Khoa:";
            this.cmb_Lop.Location = new System.Drawing.Point(25, 330);
            this.cmb_Lop.Size = new System.Drawing.Size(280, 22);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btn_Them
            this.btn_Them.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Them.Location = new System.Drawing.Point(25, 410);
            this.btn_Them.Size = new System.Drawing.Size(130, 40);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);

            // btn_Sua
            this.btn_Sua.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Sua.Location = new System.Drawing.Point(175, 410);
            this.btn_Sua.Size = new System.Drawing.Size(130, 40);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);

            // btn_Xoa
            this.btn_Xoa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Xoa.Location = new System.Drawing.Point(25, 460);
            this.btn_Xoa.Size = new System.Drawing.Size(130, 40);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);

            // btn_LamMoi
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btn_LamMoi.Location = new System.Drawing.Point(175, 460);
            this.btn_LamMoi.Size = new System.Drawing.Size(130, 40);
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);

            // dgv_Admin_SinhVien
            this.dgv_Admin_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admin_SinhVien.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Admin_SinhVien.ColumnHeadersHeight = 29;
            this.dgv_Admin_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Admin_SinhVien.Name = "dgv_Admin_SinhVien";
            this.dgv_Admin_SinhVien.RowHeadersWidth = 51;
            this.dgv_Admin_SinhVien.TabIndex = 0;
            this.dgv_Admin_SinhVien.SelectionChanged += new System.EventHandler(this.dgv_Admin_SinhVien_SelectionChanged);

            // pnl_Search
            this.pnl_Search.Controls.Add(this.txt_Search);
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Height = 45;
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.TabIndex = 1;

            // txt_Search
            this.txt_Search.Location = new System.Drawing.Point(8, 10);
            this.txt_Search.Size = new System.Drawing.Size(500, 22);
            this.txt_Search.Name = "txt_Search";

            // btn_Search
            this.btn_Search.Location = new System.Drawing.Point(520, 8);
            this.btn_Search.Size = new System.Drawing.Size(100, 28);
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Name = "btn_Search";

            // pnl_Right
            this.pnl_Right.Controls.Add(this.dgv_Admin_SinhVien);
            this.pnl_Right.Controls.Add(this.pnl_Search);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.TabIndex = 0;

            // frm_admin
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản trị Sinh viên";
            this.Load += new System.EventHandler(this.frm_admin_load);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.pnl_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.CheckBox chk_Phai;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lbl_NoiSinh;
        private System.Windows.Forms.TextBox txt_NoiSinh;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Admin_SinhVien;
    }
}
