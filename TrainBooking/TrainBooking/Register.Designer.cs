namespace TrainBooking
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgs_email = new System.Windows.Forms.TextBox();
            this.rgs_pass = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.rgs_ls = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rgs_fn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backToLogin = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rgs_email
            // 
            this.rgs_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rgs_email.Location = new System.Drawing.Point(474, 287);
            this.rgs_email.Name = "rgs_email";
            this.rgs_email.Size = new System.Drawing.Size(232, 30);
            this.rgs_email.TabIndex = 4;
            this.rgs_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // rgs_pass
            // 
            this.rgs_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rgs_pass.Location = new System.Drawing.Point(474, 349);
            this.rgs_pass.Name = "rgs_pass";
            this.rgs_pass.Size = new System.Drawing.Size(232, 30);
            this.rgs_pass.TabIndex = 5;
            this.rgs_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reg.Location = new System.Drawing.Point(369, 431);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(151, 56);
            this.btn_reg.TabIndex = 6;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // rgs_ls
            // 
            this.rgs_ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rgs_ls.Location = new System.Drawing.Point(474, 236);
            this.rgs_ls.Name = "rgs_ls";
            this.rgs_ls.Size = new System.Drawing.Size(232, 30);
            this.rgs_ls.TabIndex = 3;
            this.rgs_ls.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rgs_fn
            // 
            this.rgs_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rgs_fn.Location = new System.Drawing.Point(474, 180);
            this.rgs_fn.Name = "rgs_fn";
            this.rgs_fn.Size = new System.Drawing.Size(232, 30);
            this.rgs_fn.TabIndex = 2;
            this.rgs_fn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(22, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Have an email?";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.backToLogin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 620);
            this.panel1.TabIndex = 13;
            // 
            // backToLogin
            // 
            this.backToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.backToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.backToLogin.FlatAppearance.BorderSize = 0;
            this.backToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLogin.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.backToLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.backToLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.backToLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.backToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToLogin.Location = new System.Drawing.Point(7, 503);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(223, 114);
            this.backToLogin.TabIndex = 7;
            this.backToLogin.Text = "     Login";
            this.backToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backToLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backToLogin.UseVisualStyleBackColor = false;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NSimSun", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "GO FASTER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainBooking.Properties.Resources.icons8_subway_100;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(279, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 40);
            this.label7.TabIndex = 14;
            this.label7.Text = "User Type :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // user_type
            // 
            this.user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "ADMIN",
            "CUSTOMER"});
            this.user_type.Location = new System.Drawing.Point(474, 131);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(232, 30);
            this.user_type.TabIndex = 1;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(728, 620);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rgs_fn);
            this.Controls.Add(this.rgs_ls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.rgs_pass);
            this.Controls.Add(this.rgs_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rgs_email;
        private System.Windows.Forms.TextBox rgs_pass;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox rgs_ls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rgs_fn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton backToLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox user_type;
    }
}