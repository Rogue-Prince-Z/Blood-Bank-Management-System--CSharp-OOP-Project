using System;

namespace BloodBankManagementSystem
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.AvailableLbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.HNameTb = new System.Windows.Forms.TextBox();
            this.HospitalIdCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BGroupCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 719);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(82, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blood Request";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel3.Location = new System.Drawing.Point(25, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 25);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 54);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Bank Management System";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(787, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 28);
            this.label12.TabIndex = 61;
            this.label12.Text = "Blood Request";
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.Color.Black;
            this.RequestBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.White;
            this.RequestBtn.Location = new System.Drawing.Point(819, 506);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(134, 45);
            this.RequestBtn.TabIndex = 71;
            this.RequestBtn.Text = "Request";
            this.RequestBtn.UseVisualStyleBackColor = false;
            this.RequestBtn.Visible = false;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // AvailableLbl
            // 
            this.AvailableLbl.AutoSize = true;
            this.AvailableLbl.Font = new System.Drawing.Font("Lucida Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.AvailableLbl.Location = new System.Drawing.Point(776, 418);
            this.AvailableLbl.Name = "AvailableLbl";
            this.AvailableLbl.Size = new System.Drawing.Size(234, 32);
            this.AvailableLbl.TabIndex = 70;
            this.AvailableLbl.Text = "AvailableOrNot";
            this.AvailableLbl.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(1127, 322);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(204, 10);
            this.panel10.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(1122, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 27);
            this.label11.TabIndex = 68;
            this.label11.Text = "Blood Group";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(792, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 10);
            this.panel4.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(787, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 27);
            this.label7.TabIndex = 65;
            this.label7.Text = "Hospital Name";
            // 
            // HNameTb
            // 
            this.HNameTb.BackColor = System.Drawing.Color.White;
            this.HNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HNameTb.Enabled = false;
            this.HNameTb.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.HNameTb.Location = new System.Drawing.Point(792, 287);
            this.HNameTb.Multiline = true;
            this.HNameTb.Name = "HNameTb";
            this.HNameTb.Size = new System.Drawing.Size(204, 30);
            this.HNameTb.TabIndex = 64;
            // 
            // HospitalIdCb
            // 
            this.HospitalIdCb.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.HospitalIdCb.FormattingEnabled = true;
            this.HospitalIdCb.Location = new System.Drawing.Point(483, 283);
            this.HospitalIdCb.Name = "HospitalIdCb";
            this.HospitalIdCb.Size = new System.Drawing.Size(204, 34);
            this.HospitalIdCb.TabIndex = 63;
            this.HospitalIdCb.SelectionChangeCommitted += new System.EventHandler(this.HospitalIdCb_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label13.Location = new System.Drawing.Point(478, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 27);
            this.label13.TabIndex = 62;
            this.label13.Text = "Hospital ID";
            // 
            // BGroupCb
            // 
            this.BGroupCb.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGroupCb.FormattingEnabled = true;
            this.BGroupCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.BGroupCb.Location = new System.Drawing.Point(1127, 287);
            this.BGroupCb.Name = "BGroupCb";
            this.BGroupCb.Size = new System.Drawing.Size(204, 29);
            this.BGroupCb.TabIndex = 72;
            this.BGroupCb.SelectionChangeCommitted += new System.EventHandler(this.BGroupCb_SelectionChangeCommitted);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 719);
            this.Controls.Add(this.BGroupCb);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.AvailableLbl);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HNameTb);
            this.Controls.Add(this.HospitalIdCb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Label AvailableLbl;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HNameTb;
        private System.Windows.Forms.ComboBox HospitalIdCb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BGroupCb;
    }
}