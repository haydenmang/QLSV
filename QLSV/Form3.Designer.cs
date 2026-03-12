namespace QLSV
{
    partial class frm_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dgv_Admin_SinhVien = new System.Windows.Forms.DataGridView();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.txt_NoiSinh = new System.Windows.Forms.TextBox();
            this.lbl_NoiSinh = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).BeginInit();
            this.pnl_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Admin_SinhVien
            // 
            this.dgv_Admin_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Admin_SinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Admin_SinhVien.ColumnHeadersHeight = 29;
            this.dgv_Admin_SinhVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_Admin_SinhVien.Location = new System.Drawing.Point(350, 0);
            this.dgv_Admin_SinhVien.Name = "dgv_Admin_SinhVien";
            this.dgv_Admin_SinhVien.RowHeadersWidth = 51;
            this.dgv_Admin_SinhVien.Size = new System.Drawing.Size(650, 600);
            this.dgv_Admin_SinhVien.TabIndex = 0;
            this.dgv_Admin_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Admin_SinhVien_CellContentClick);
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.btn_LamMoi);
            this.pnl_Left.Controls.Add(this.btn_Xoa);
            this.pnl_Left.Controls.Add(this.btn_Sua);
            this.pnl_Left.Controls.Add(this.btn_Them);
            this.pnl_Left.Controls.Add(this.txt_Lop);
            this.pnl_Left.Controls.Add(this.lbl_Lop);
            this.pnl_Left.Controls.Add(this.txt_NoiSinh);
            this.pnl_Left.Controls.Add(this.lbl_NoiSinh);
            this.pnl_Left.Controls.Add(this.dtp_NgaySinh);
            this.pnl_Left.Controls.Add(this.lbl_NgaySinh);
            this.pnl_Left.Controls.Add(this.txt_HoTen);
            this.pnl_Left.Controls.Add(this.lbl_HoTen);
            this.pnl_Left.Controls.Add(this.txt_MaSV);
            this.pnl_Left.Controls.Add(this.lbl_MaSV);
            this.pnl_Left.Controls.Add(this.lbl_Title);
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(350, 600);
            this.pnl_Left.TabIndex = 1;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightGray;
            this.btn_LamMoi.Location = new System.Drawing.Point(175, 490);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(130, 40);
            this.btn_LamMoi.TabIndex = 0;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Xoa.Location = new System.Drawing.Point(25, 490);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(130, 40);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Sua.Location = new System.Drawing.Point(175, 430);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(130, 40);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Them.Location = new System.Drawing.Point(25, 430);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 40);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // txt_Lop
            // 
            this.txt_Lop.Location = new System.Drawing.Point(25, 375);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(280, 22);
            this.txt_Lop.TabIndex = 4;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.Location = new System.Drawing.Point(25, 350);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(100, 23);
            this.lbl_Lop.TabIndex = 5;
            this.lbl_Lop.Text = "Lớp:";
            // 
            // txt_NoiSinh
            // 
            this.txt_NoiSinh.Location = new System.Drawing.Point(25, 305);
            this.txt_NoiSinh.Name = "txt_NoiSinh";
            this.txt_NoiSinh.Size = new System.Drawing.Size(280, 22);
            this.txt_NoiSinh.TabIndex = 6;
            // 
            // lbl_NoiSinh
            // 
            this.lbl_NoiSinh.Location = new System.Drawing.Point(25, 280);
            this.lbl_NoiSinh.Name = "lbl_NoiSinh";
            this.lbl_NoiSinh.Size = new System.Drawing.Size(100, 23);
            this.lbl_NoiSinh.TabIndex = 7;
            this.lbl_NoiSinh.Text = "Nơi sinh:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(25, 235);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(280, 22);
            this.dtp_NgaySinh.TabIndex = 8;
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Location = new System.Drawing.Point(25, 210);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lbl_NgaySinh.TabIndex = 9;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(25, 165);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(280, 22);
            this.txt_HoTen.TabIndex = 10;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Location = new System.Drawing.Point(25, 140);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(100, 23);
            this.lbl_HoTen.TabIndex = 11;
            this.lbl_HoTen.Text = "Họ và tên:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(25, 95);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(280, 22);
            this.txt_MaSV.TabIndex = 12;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.Location = new System.Drawing.Point(25, 70);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(100, 23);
            this.lbl_MaSV.TabIndex = 13;
            this.lbl_MaSV.Text = "Mã sinh viên:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(20, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(300, 30);
            this.lbl_Title.TabIndex = 14;
            this.lbl_Title.Text = "Thông tin sinh viên";
            // 
            // frm_admin
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.dgv_Admin_SinhVien);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản trị Sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admin_SinhVien)).EndInit();
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        // Khai báo biến (Dán vào phía dưới cùng của file Designer)
        private System.Windows.Forms.DataGridView dgv_Admin_SinhVien;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_NoiSinh;
        private System.Windows.Forms.Label lbl_NoiSinh;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_LamMoi;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}