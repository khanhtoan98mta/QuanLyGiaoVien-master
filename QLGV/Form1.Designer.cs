namespace QLGV
{
    partial class Form1
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
            this.btn_Dat = new System.Windows.Forms.Button();
            this.btn_Toan = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Dat
            // 
            this.btn_Dat.Location = new System.Drawing.Point(24, 30);
            this.btn_Dat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dat.Name = "btn_Dat";
            this.btn_Dat.Size = new System.Drawing.Size(106, 46);
            this.btn_Dat.TabIndex = 0;
            this.btn_Dat.Text = "Trần Mạnh Đạt";
            this.btn_Dat.UseVisualStyleBackColor = true;
            this.btn_Dat.Click += new System.EventHandler(this.btn_Dat_Click);
            // 
            // btn_Toan
            // 
            this.btn_Toan.Location = new System.Drawing.Point(152, 30);
            this.btn_Toan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Toan.Name = "btn_Toan";
            this.btn_Toan.Size = new System.Drawing.Size(106, 46);
            this.btn_Toan.TabIndex = 1;
            this.btn_Toan.Text = "Vũ Khánh Toàn";
            this.btn_Toan.UseVisualStyleBackColor = true;
            this.btn_Toan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(278, 30);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(106, 46);
            this.btn_Dong.TabIndex = 2;
            this.btn_Dong.Text = "Hồ Ngọc Đồng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 112);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Toan);
            this.Controls.Add(this.btn_Dat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giáo Viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dat;
        private System.Windows.Forms.Button btn_Toan;
        private System.Windows.Forms.Button btn_Dong;
    }
}

