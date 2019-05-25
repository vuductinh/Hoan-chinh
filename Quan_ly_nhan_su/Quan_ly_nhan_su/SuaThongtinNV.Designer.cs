namespace Quan_ly_nhan_su
{
    partial class SuaThongtinNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_hoten = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.cb_phongban = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_luong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quequan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bt_thoat);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cb_chucvu);
            this.groupBox1.Controls.Add(this.cb_phongban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_luong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_quequan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(307, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sửa";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(208, 381);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(100, 28);
            this.bt_thoat.TabIndex = 15;
            this.bt_thoat.Text = "Trở về";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(91, 381);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(100, 28);
            this.bt_sua.TabIndex = 14;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_hoten);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 90);
            this.panel1.TabIndex = 13;
            // 
            // cb_hoten
            // 
            this.cb_hoten.FormattingEnabled = true;
            this.cb_hoten.Location = new System.Drawing.Point(6, 55);
            this.cb_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.cb_hoten.Name = "cb_hoten";
            this.cb_hoten.Size = new System.Drawing.Size(230, 24);
            this.cb_hoten.TabIndex = 16;
            this.cb_hoten.SelectedIndexChanged += new System.EventHandler(this.cb_hoten_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vui lòng nhập mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ Tên nhân viên";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.Location = new System.Drawing.Point(38, 206);
            this.cb_chucvu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(230, 24);
            this.cb_chucvu.TabIndex = 12;
            this.cb_chucvu.SelectedIndexChanged += new System.EventHandler(this.cb_chucvu_SelectedIndexChanged);
            // 
            // cb_phongban
            // 
            this.cb_phongban.FormattingEnabled = true;
            this.cb_phongban.Location = new System.Drawing.Point(38, 137);
            this.cb_phongban.Margin = new System.Windows.Forms.Padding(4);
            this.cb_phongban.Name = "cb_phongban";
            this.cb_phongban.Size = new System.Drawing.Size(230, 24);
            this.cb_phongban.TabIndex = 11;
            this.cb_phongban.SelectedIndexChanged += new System.EventHandler(this.cb_phongban_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lương";
            // 
            // cb_luong
            // 
            this.cb_luong.FormattingEnabled = true;
            this.cb_luong.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000"});
            this.cb_luong.Location = new System.Drawing.Point(36, 330);
            this.cb_luong.Margin = new System.Windows.Forms.Padding(4);
            this.cb_luong.Name = "cb_luong";
            this.cb_luong.Size = new System.Drawing.Size(232, 24);
            this.cb_luong.TabIndex = 8;
            this.cb_luong.SelectedIndexChanged += new System.EventHandler(this.cb_luong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quê quán";
            // 
            // tb_quequan
            // 
            this.tb_quequan.Location = new System.Drawing.Point(38, 269);
            this.tb_quequan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quequan.Name = "tb_quequan";
            this.tb_quequan.Size = new System.Drawing.Size(230, 22);
            this.tb_quequan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng ban";
            // 
            // SuaThongtinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 490);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SuaThongtinNV";
            this.Text = "SuaThongtinNV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_chucvu;
        private System.Windows.Forms.ComboBox cb_phongban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_luong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_quequan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_hoten;
    }
}