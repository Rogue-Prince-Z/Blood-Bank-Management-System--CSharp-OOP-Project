namespace BloodBankManagementSystem
{
    partial class Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DNameTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DAgeTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DPhoneTb = new System.Windows.Forms.TextBox();
            this.DGenCb = new System.Windows.Forms.ComboBox();
            this.DBGroupCb = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DAddressTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 719);
            this.panel1.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(53, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 28);
            this.label17.TabIndex = 24;
            this.label17.Text = "Donate";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Blood Stock";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "View Patient";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patient";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blood Transfer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "View Donor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel3.Location = new System.Drawing.Point(20, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 25);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 54);
            this.panel2.TabIndex = 2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(841, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Donor";
            // 
            // DNameTb
            // 
            this.DNameTb.BackColor = System.Drawing.Color.White;
            this.DNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DNameTb.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNameTb.Location = new System.Drawing.Point(375, 227);
            this.DNameTb.Multiline = true;
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(204, 30);
            this.DNameTb.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(370, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label12.Location = new System.Drawing.Point(763, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "Age";
            // 
            // DAgeTb
            // 
            this.DAgeTb.BackColor = System.Drawing.Color.White;
            this.DAgeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DAgeTb.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAgeTb.Location = new System.Drawing.Point(768, 227);
            this.DAgeTb.Multiline = true;
            this.DAgeTb.Name = "DAgeTb";
            this.DAgeTb.Size = new System.Drawing.Size(204, 30);
            this.DAgeTb.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label13.Location = new System.Drawing.Point(1153, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 27);
            this.label13.TabIndex = 10;
            this.label13.Text = "Gender";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label14.Location = new System.Drawing.Point(370, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 27);
            this.label14.TabIndex = 12;
            this.label14.Text = "Phone";
            // 
            // DPhoneTb
            // 
            this.DPhoneTb.BackColor = System.Drawing.Color.White;
            this.DPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DPhoneTb.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPhoneTb.Location = new System.Drawing.Point(375, 388);
            this.DPhoneTb.Multiline = true;
            this.DPhoneTb.Name = "DPhoneTb";
            this.DPhoneTb.Size = new System.Drawing.Size(204, 30);
            this.DPhoneTb.TabIndex = 11;
            // 
            // DGenCb
            // 
            this.DGenCb.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGenCb.FormattingEnabled = true;
            this.DGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DGenCb.Location = new System.Drawing.Point(1158, 239);
            this.DGenCb.Name = "DGenCb";
            this.DGenCb.Size = new System.Drawing.Size(204, 29);
            this.DGenCb.TabIndex = 13;
            // 
            // DBGroupCb
            // 
            this.DBGroupCb.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBGroupCb.FormattingEnabled = true;
            this.DBGroupCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.DBGroupCb.Location = new System.Drawing.Point(1158, 400);
            this.DBGroupCb.Name = "DBGroupCb";
            this.DBGroupCb.Size = new System.Drawing.Size(204, 29);
            this.DBGroupCb.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label15.Location = new System.Drawing.Point(1153, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "Blood Group";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label16.Location = new System.Drawing.Point(763, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 27);
            this.label16.TabIndex = 16;
            this.label16.Text = "Address";
            // 
            // DAddressTb
            // 
            this.DAddressTb.BackColor = System.Drawing.Color.White;
            this.DAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DAddressTb.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAddressTb.Location = new System.Drawing.Point(768, 404);
            this.DAddressTb.Multiline = true;
            this.DAddressTb.Name = "DAddressTb";
            this.DAddressTb.Size = new System.Drawing.Size(289, 142);
            this.DAddressTb.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(846, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(375, 263);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(204, 10);
            this.panel10.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(768, 263);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(204, 10);
            this.panel11.TabIndex = 20;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(375, 424);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(204, 10);
            this.panel12.TabIndex = 21;
            // 
            // Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 719);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DAddressTb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DBGroupCb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DGenCb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DPhoneTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DAgeTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Donor_Load);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DAgeTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DPhoneTb;
        private System.Windows.Forms.ComboBox DGenCb;
        private System.Windows.Forms.ComboBox DBGroupCb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DAddressTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label17;
    }
}