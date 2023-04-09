
namespace quanlysinhvien
{
    partial class quenmatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quenmatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttk1 = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btxacnhan = new System.Windows.Forms.Button();
            this.btthoat5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txttk1
            // 
            this.txttk1.Location = new System.Drawing.Point(308, 94);
            this.txttk1.Name = "txttk1";
            this.txttk1.Size = new System.Drawing.Size(116, 22);
            this.txttk1.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(308, 208);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(116, 22);
            this.txtten.TabIndex = 7;
            this.txtten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(308, 152);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(116, 22);
            this.txtmsv.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(308, 256);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(116, 22);
            this.txtemail.TabIndex = 8;
            // 
            // btxacnhan
            // 
            this.btxacnhan.Location = new System.Drawing.Point(146, 343);
            this.btxacnhan.Name = "btxacnhan";
            this.btxacnhan.Size = new System.Drawing.Size(119, 32);
            this.btxacnhan.TabIndex = 10;
            this.btxacnhan.Text = "Xác nhận";
            this.btxacnhan.UseVisualStyleBackColor = true;
            this.btxacnhan.Click += new System.EventHandler(this.btxacnhan_Click);
            // 
            // btthoat5
            // 
            this.btthoat5.Location = new System.Drawing.Point(389, 343);
            this.btthoat5.Name = "btthoat5";
            this.btthoat5.Size = new System.Drawing.Size(78, 32);
            this.btthoat5.TabIndex = 11;
            this.btthoat5.Text = "Thoát";
            this.btthoat5.UseVisualStyleBackColor = true;
            this.btthoat5.Click += new System.EventHandler(this.btthoat5_Click);
            // 
            // quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 438);
            this.Controls.Add(this.btthoat5);
            this.Controls.Add(this.btxacnhan);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txttk1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quenmatkhau";
            this.Text = "quenmatkhau";
            this.Load += new System.EventHandler(this.quenmatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttk1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btxacnhan;
        private System.Windows.Forms.Button btthoat5;
    }
}