namespace Quan_ly_nhan_su
{
    partial class XoaNV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xóa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_maxoa = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.bt_thoat);
            this.groupBox2.Controls.Add(this.bt_xóa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_maxoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(18, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(274, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xóa";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(159, 101);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(84, 32);
            this.bt_thoat.TabIndex = 16;
            this.bt_thoat.Text = "Trở về";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xóa
            // 
            this.bt_xóa.Location = new System.Drawing.Point(77, 101);
            this.bt_xóa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_xóa.Name = "bt_xóa";
            this.bt_xóa.Size = new System.Drawing.Size(78, 32);
            this.bt_xóa.TabIndex = 15;
            this.bt_xóa.Text = "Xóa";
            this.bt_xóa.UseVisualStyleBackColor = true;
            this.bt_xóa.Click += new System.EventHandler(this.bt_xóa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vui lòng nhập Mã nhân viên cần xóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã nhân viên";
            // 
            // tb_maxoa
            // 
            this.tb_maxoa.Location = new System.Drawing.Point(13, 66);
            this.tb_maxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_maxoa.Multiline = true;
            this.tb_maxoa.Name = "tb_maxoa";
            this.tb_maxoa.Size = new System.Drawing.Size(208, 29);
            this.tb_maxoa.TabIndex = 1;
            // 
            // XoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 175);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "XoaNV";
            this.Text = "Xóa_nhân_viên";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xóa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_maxoa;
    }
}