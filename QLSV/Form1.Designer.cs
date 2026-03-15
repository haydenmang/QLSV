namespace QLSV
{
    partial class frm_login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_1 = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.txb_1 = new System.Windows.Forms.TextBox();
            this.txb_2 = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(326, 285);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(120, 57);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "Login";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(70, 129);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(68, 16);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "Tài Khoản";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(72, 178);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(61, 16);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "Mật khẩu";
            // 
            // txb_1
            // 
            this.txb_1.Location = new System.Drawing.Point(161, 127);
            this.txb_1.Name = "txb_1";
            this.txb_1.Size = new System.Drawing.Size(201, 22);
            this.txb_1.TabIndex = 3;
            // 
            // txb_2
            // 
            this.txb_2.Location = new System.Drawing.Point(161, 178);
            this.txb_2.Name = "txb_2";
            this.txb_2.Size = new System.Drawing.Size(201, 22);
            this.txb_2.TabIndex = 4;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(137, 45);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(120, 25);
            this.lb_login.TabIndex = 5;
            this.lb_login.Text = "Đăng Nhập";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.txb_2);
            this.Controls.Add(this.txb_1);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.bt_1);
            this.Name = "frm_login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.TextBox txb_1;
        private System.Windows.Forms.TextBox txb_2;
        private System.Windows.Forms.Label lb_login;
    }
}

