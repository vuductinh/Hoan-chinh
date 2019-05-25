namespace Quan_ly_nhan_su
{
    partial class Luongnhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luongnhanvien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_tháng = new System.Windows.Forms.ComboBox();
            this.cb_năm = new System.Windows.Forms.ComboBox();
            this.tb_tongthuong = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.lb_tinhluong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_tinhluong = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bhxh = new System.Windows.Forms.TextBox();
            this.tb_luongcb = new System.Windows.Forms.TextBox();
            this.cb_ma = new System.Windows.Forms.ComboBox();
            this.tb_bhtn = new System.Windows.Forms.TextBox();
            this.tb_heso = new System.Windows.Forms.TextBox();
            this.tb_hsphucap = new System.Windows.Forms.TextBox();
            this.tb_BHYT = new System.Windows.Forms.TextBox();
            this.bt_luong = new System.Windows.Forms.Button();
            this.addluong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(887, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_tháng
            // 
            this.cb_tháng.FormattingEnabled = true;
            this.cb_tháng.Location = new System.Drawing.Point(182, 239);
            this.cb_tháng.Name = "cb_tháng";
            this.cb_tháng.Size = new System.Drawing.Size(121, 21);
            this.cb_tháng.TabIndex = 1;
            this.cb_tháng.Text = "chọn phòng ban";
            this.cb_tháng.SelectedIndexChanged += new System.EventHandler(this.cb_tháng_SelectedIndexChanged);
            // 
            // cb_năm
            // 
            this.cb_năm.FormattingEnabled = true;
            this.cb_năm.Items.AddRange(new object[] {
            "2019"});
            this.cb_năm.Location = new System.Drawing.Point(15, 238);
            this.cb_năm.Name = "cb_năm";
            this.cb_năm.Size = new System.Drawing.Size(121, 21);
            this.cb_năm.TabIndex = 2;
            this.cb_năm.Text = "lựa chọn năm";
            // 
            // tb_tongthuong
            // 
            this.tb_tongthuong.Location = new System.Drawing.Point(347, 239);
            this.tb_tongthuong.Name = "tb_tongthuong";
            this.tb_tongthuong.Size = new System.Drawing.Size(58, 20);
            this.tb_tongthuong.TabIndex = 3;
            this.tb_tongthuong.Text = "0";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.White;
            this.bt_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_thoat.BackgroundImage")));
            this.bt_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_thoat.Location = new System.Drawing.Point(826, 6);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(73, 31);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(179, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Năm";
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.ForeColor = System.Drawing.Color.Blue;
            this.lb_thongtin.Location = new System.Drawing.Point(344, 222);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(61, 13);
            this.lb_thongtin.TabIndex = 8;
            this.lb_thongtin.Text = "Tổng lương";
            // 
            // lb_tinhluong
            // 
            this.lb_tinhluong.AutoSize = true;
            this.lb_tinhluong.ForeColor = System.Drawing.Color.Blue;
            this.lb_tinhluong.Location = new System.Drawing.Point(465, 269);
            this.lb_tinhluong.Name = "lb_tinhluong";
            this.lb_tinhluong.Size = new System.Drawing.Size(30, 13);
            this.lb_tinhluong.TabIndex = 9;
            this.lb_tinhluong.Text = "Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh lương nhân viên";
            // 
            // bt_tinhluong
            // 
            this.bt_tinhluong.BackColor = System.Drawing.Color.White;
            this.bt_tinhluong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_tinhluong.BackgroundImage")));
            this.bt_tinhluong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_tinhluong.Location = new System.Drawing.Point(468, 210);
            this.bt_tinhluong.Name = "bt_tinhluong";
            this.bt_tinhluong.Size = new System.Drawing.Size(58, 49);
            this.bt_tinhluong.TabIndex = 11;
            this.bt_tinhluong.UseVisualStyleBackColor = false;
            this.bt_tinhluong.Click += new System.EventHandler(this.bt_tinhluong_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(355, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(190, 25);
            this.label19.TabIndex = 56;
            this.label19.Text = "Danh Mục Lương";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_bhxh);
            this.groupBox1.Controls.Add(this.tb_luongcb);
            this.groupBox1.Controls.Add(this.cb_ma);
            this.groupBox1.Controls.Add(this.tb_bhtn);
            this.groupBox1.Controls.Add(this.tb_heso);
            this.groupBox1.Controls.Add(this.tb_hsphucap);
            this.groupBox1.Controls.Add(this.tb_BHYT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(15, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 161);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay đổi thông tin lương";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "BHYT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "BHXH";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(555, 118);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(37, 13);
            this.label0.TabIndex = 10;
            this.label0.Text = "BHTN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hệ số phụ cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hệ số lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lương cơ bản";
            // 
            // tb_bhxh
            // 
            this.tb_bhxh.Location = new System.Drawing.Point(345, 118);
            this.tb_bhxh.Name = "tb_bhxh";
            this.tb_bhxh.Size = new System.Drawing.Size(100, 20);
            this.tb_bhxh.TabIndex = 6;
            // 
            // tb_luongcb
            // 
            this.tb_luongcb.Location = new System.Drawing.Point(94, 71);
            this.tb_luongcb.Name = "tb_luongcb";
            this.tb_luongcb.Size = new System.Drawing.Size(100, 20);
            this.tb_luongcb.TabIndex = 5;
            // 
            // cb_ma
            // 
            this.cb_ma.FormattingEnabled = true;
            this.cb_ma.Location = new System.Drawing.Point(6, 44);
            this.cb_ma.Name = "cb_ma";
            this.cb_ma.Size = new System.Drawing.Size(82, 21);
            this.cb_ma.TabIndex = 4;
            this.cb_ma.SelectedIndexChanged += new System.EventHandler(this.cb_ma_SelectedIndexChanged);
            // 
            // tb_bhtn
            // 
            this.tb_bhtn.Location = new System.Drawing.Point(596, 111);
            this.tb_bhtn.Name = "tb_bhtn";
            this.tb_bhtn.Size = new System.Drawing.Size(100, 20);
            this.tb_bhtn.TabIndex = 3;
            // 
            // tb_heso
            // 
            this.tb_heso.Location = new System.Drawing.Point(345, 71);
            this.tb_heso.Name = "tb_heso";
            this.tb_heso.Size = new System.Drawing.Size(100, 20);
            this.tb_heso.TabIndex = 2;
            // 
            // tb_hsphucap
            // 
            this.tb_hsphucap.Location = new System.Drawing.Point(596, 71);
            this.tb_hsphucap.Name = "tb_hsphucap";
            this.tb_hsphucap.Size = new System.Drawing.Size(100, 20);
            this.tb_hsphucap.TabIndex = 1;
            // 
            // tb_BHYT
            // 
            this.tb_BHYT.Location = new System.Drawing.Point(94, 118);
            this.tb_BHYT.Name = "tb_BHYT";
            this.tb_BHYT.Size = new System.Drawing.Size(100, 20);
            this.tb_BHYT.TabIndex = 0;
            // 
            // bt_luong
            // 
            this.bt_luong.ForeColor = System.Drawing.Color.Blue;
            this.bt_luong.Location = new System.Drawing.Point(701, 230);
            this.bt_luong.Name = "bt_luong";
            this.bt_luong.Size = new System.Drawing.Size(87, 30);
            this.bt_luong.TabIndex = 58;
            this.bt_luong.Text = "Thay đổi lương";
            this.bt_luong.UseVisualStyleBackColor = true;
            this.bt_luong.Click += new System.EventHandler(this.bt_luong_Click);
            // 
            // addluong
            // 
            this.addluong.ForeColor = System.Drawing.Color.Blue;
            this.addluong.Location = new System.Drawing.Point(573, 229);
            this.addluong.Name = "addluong";
            this.addluong.Size = new System.Drawing.Size(87, 30);
            this.addluong.TabIndex = 59;
            this.addluong.Text = "Thêm lương";
            this.addluong.UseVisualStyleBackColor = true;
            this.addluong.Click += new System.EventHandler(this.addluong_Click);
            // 
            // Luongnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 541);
            this.Controls.Add(this.bt_luong);
            this.Controls.Add(this.addluong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_tinhluong);
            this.Controls.Add(this.lb_tinhluong);
            this.Controls.Add(this.lb_thongtin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.tb_tongthuong);
            this.Controls.Add(this.cb_năm);
            this.Controls.Add(this.cb_tháng);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Luongnhanvien";
            this.Text = "Quản Lí Lương";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_tháng;
        private System.Windows.Forms.ComboBox cb_năm;
        private System.Windows.Forms.TextBox tb_tongthuong;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Label lb_tinhluong;
        private System.Windows.Forms.Button bt_tinhluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bhxh;
        private System.Windows.Forms.TextBox tb_luongcb;
        private System.Windows.Forms.ComboBox cb_ma;
        private System.Windows.Forms.TextBox tb_bhtn;
        private System.Windows.Forms.TextBox tb_heso;
        private System.Windows.Forms.TextBox tb_hsphucap;
        private System.Windows.Forms.TextBox tb_BHYT;
        private System.Windows.Forms.Button bt_luong;
        private System.Windows.Forms.Button addluong;
    }
}