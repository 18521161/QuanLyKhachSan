namespace QLKS
{
    partial class AddNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CB_ChucVu = new System.Windows.Forms.ComboBox();
            this.LB_DC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TB_SDT = new System.Windows.Forms.TextBox();
            this.LB_SDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TB_TenNhanVien = new System.Windows.Forms.TextBox();
            this.LB_Ten = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TB_IDNV = new System.Windows.Forms.TextBox();
            this.LB_TTK = new System.Windows.Forms.Label();
            this.TB_Ten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 268);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 50);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm nhân viên";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CB_ChucVu);
            this.panel6.Controls.Add(this.LB_DC);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(333, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 71);
            this.panel6.TabIndex = 3;
            // 
            // CB_ChucVu
            // 
            this.CB_ChucVu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CB_ChucVu.FormattingEnabled = true;
            this.CB_ChucVu.Items.AddRange(new object[] {
            "Bảo vệ",
            "Đầu bếp ",
            "Phụ bếp",
            "Quản lý"});
            this.CB_ChucVu.Location = new System.Drawing.Point(15, 36);
            this.CB_ChucVu.Name = "CB_ChucVu";
            this.CB_ChucVu.Size = new System.Drawing.Size(269, 21);
            this.CB_ChucVu.TabIndex = 6;
            // 
            // LB_DC
            // 
            this.LB_DC.AutoSize = true;
            this.LB_DC.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LB_DC.Location = new System.Drawing.Point(13, 36);
            this.LB_DC.Name = "LB_DC";
            this.LB_DC.Size = new System.Drawing.Size(0, 21);
            this.LB_DC.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chức vụ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TB_SDT);
            this.panel5.Controls.Add(this.LB_SDT);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(23, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 71);
            this.panel5.TabIndex = 3;
            // 
            // TB_SDT
            // 
            this.TB_SDT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TB_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SDT.Location = new System.Drawing.Point(12, 36);
            this.TB_SDT.Name = "TB_SDT";
            this.TB_SDT.Size = new System.Drawing.Size(269, 21);
            this.TB_SDT.TabIndex = 3;
            // 
            // LB_SDT
            // 
            this.LB_SDT.AutoSize = true;
            this.LB_SDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SDT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LB_SDT.Location = new System.Drawing.Point(13, 36);
            this.LB_SDT.Name = "LB_SDT";
            this.LB_SDT.Size = new System.Drawing.Size(0, 21);
            this.LB_SDT.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TB_TenNhanVien);
            this.panel4.Controls.Add(this.LB_Ten);
            this.panel4.Controls.Add(this.label);
            this.panel4.Location = new System.Drawing.Point(333, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 71);
            this.panel4.TabIndex = 3;
            // 
            // TB_TenNhanVien
            // 
            this.TB_TenNhanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TB_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TenNhanVien.Location = new System.Drawing.Point(15, 36);
            this.TB_TenNhanVien.Name = "TB_TenNhanVien";
            this.TB_TenNhanVien.Size = new System.Drawing.Size(269, 21);
            this.TB_TenNhanVien.TabIndex = 3;
            // 
            // LB_Ten
            // 
            this.LB_Ten.AutoSize = true;
            this.LB_Ten.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Ten.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LB_Ten.Location = new System.Drawing.Point(13, 36);
            this.LB_Ten.Name = "LB_Ten";
            this.LB_Ten.Size = new System.Drawing.Size(0, 21);
            this.LB_Ten.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Họ và tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TB_IDNV);
            this.panel3.Controls.Add(this.LB_TTK);
            this.panel3.Controls.Add(this.TB_Ten);
            this.panel3.Location = new System.Drawing.Point(23, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 71);
            this.panel3.TabIndex = 2;
            // 
            // TB_IDNV
            // 
            this.TB_IDNV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TB_IDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IDNV.Location = new System.Drawing.Point(12, 36);
            this.TB_IDNV.Name = "TB_IDNV";
            this.TB_IDNV.Size = new System.Drawing.Size(269, 21);
            this.TB_IDNV.TabIndex = 2;
            // 
            // LB_TTK
            // 
            this.LB_TTK.AutoSize = true;
            this.LB_TTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TTK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LB_TTK.Location = new System.Drawing.Point(13, 36);
            this.LB_TTK.Name = "LB_TTK";
            this.LB_TTK.Size = new System.Drawing.Size(0, 21);
            this.LB_TTK.TabIndex = 1;
            // 
            // TB_Ten
            // 
            this.TB_Ten.AutoSize = true;
            this.TB_Ten.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ten.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TB_Ten.Location = new System.Drawing.Point(12, 9);
            this.TB_Ten.Name = "TB_Ten";
            this.TB_Ten.Size = new System.Drawing.Size(24, 17);
            this.TB_Ten.TabIndex = 0;
            this.TB_Ten.Text = "ID";
            // 
            // AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 266);
            this.Controls.Add(this.panel1);
            this.Name = "AddNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox CB_ChucVu;
        private System.Windows.Forms.Label LB_DC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TB_SDT;
        private System.Windows.Forms.Label LB_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TB_TenNhanVien;
        private System.Windows.Forms.Label LB_Ten;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TB_IDNV;
        private System.Windows.Forms.Label LB_TTK;
        private System.Windows.Forms.Label TB_Ten;
    }
}