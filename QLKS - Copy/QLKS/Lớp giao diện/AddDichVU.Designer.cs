namespace QLKS
{
    partial class AddDichVU
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
            this.DTGV_DV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_DVK = new System.Windows.Forms.Button();
            this.BT_GL = new System.Windows.Forms.Button();
            this.BT_MNB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.DTGV_DV);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 305);
            this.panel1.TabIndex = 7;
            // 
            // DTGV_DV
            // 
            this.DTGV_DV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTGV_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_DV.Location = new System.Drawing.Point(329, 57);
            this.DTGV_DV.Name = "DTGV_DV";
            this.DTGV_DV.Size = new System.Drawing.Size(323, 245);
            this.DTGV_DV.TabIndex = 4;
            this.DTGV_DV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_DV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_DVK);
            this.panel3.Controls.Add(this.BT_GL);
            this.panel3.Controls.Add(this.BT_MNB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 245);
            this.panel3.TabIndex = 5;
            // 
            // BT_DVK
            // 
            this.BT_DVK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_DVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DVK.Location = new System.Drawing.Point(8, 164);
            this.BT_DVK.Name = "BT_DVK";
            this.BT_DVK.Size = new System.Drawing.Size(296, 46);
            this.BT_DVK.TabIndex = 3;
            this.BT_DVK.Text = "Dịch vụ khác";
            this.BT_DVK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_DVK.UseVisualStyleBackColor = false;
            this.BT_DVK.Click += new System.EventHandler(this.BT_DVK_Click);
            // 
            // BT_GL
            // 
            this.BT_GL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_GL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GL.Location = new System.Drawing.Point(8, 98);
            this.BT_GL.Name = "BT_GL";
            this.BT_GL.Size = new System.Drawing.Size(296, 46);
            this.BT_GL.TabIndex = 2;
            this.BT_GL.Text = "Giặt là";
            this.BT_GL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_GL.UseVisualStyleBackColor = false;
            this.BT_GL.Click += new System.EventHandler(this.BT_GL_Click);
            // 
            // BT_MNB
            // 
            this.BT_MNB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_MNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MNB.Location = new System.Drawing.Point(8, 33);
            this.BT_MNB.Name = "BT_MNB";
            this.BT_MNB.Size = new System.Drawing.Size(296, 46);
            this.BT_MNB.TabIndex = 1;
            this.BT_MNB.Text = "Minibar";
            this.BT_MNB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_MNB.UseVisualStyleBackColor = false;
            this.BT_MNB.Click += new System.EventHandler(this.BT_MNB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm dịch vụ:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 50);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại dịch vụ";
            // 
            // AddDichVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 305);
            this.Controls.Add(this.panel1);
            this.Name = "AddDichVU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDichVU";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_DV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DTGV_DV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_DVK;
        private System.Windows.Forms.Button BT_GL;
        private System.Windows.Forms.Button BT_MNB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}