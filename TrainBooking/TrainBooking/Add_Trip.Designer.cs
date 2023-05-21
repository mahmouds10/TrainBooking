namespace TrainBooking
{
    partial class Add_Trip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Trip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.train_ID = new System.Windows.Forms.TextBox();
            this.dep_station = new System.Windows.Forms.TextBox();
            this.dep_date = new System.Windows.Forms.TextBox();
            this.dep_time = new System.Windows.Forms.TextBox();
            this.arr_station = new System.Windows.Forms.TextBox();
            this.arr_date = new System.Windows.Forms.TextBox();
            this.arr_time = new System.Windows.Forms.TextBox();
            this.max_cap = new System.Windows.Forms.TextBox();
            this.avlbl_seats = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 626);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "GO FASTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Train ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(313, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departure Station :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(313, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departure Time :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Departure Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(316, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "Arrival Station :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arrival Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(316, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 40);
            this.label9.TabIndex = 9;
            this.label9.Text = "Arrival Time :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(316, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 40);
            this.label10.TabIndex = 10;
            this.label10.Text = "Maximum Capacity :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(313, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 40);
            this.label11.TabIndex = 11;
            this.label11.Text = "Available Seats";
            // 
            // train_ID
            // 
            this.train_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_ID.Location = new System.Drawing.Point(662, 47);
            this.train_ID.Name = "train_ID";
            this.train_ID.Size = new System.Drawing.Size(187, 30);
            this.train_ID.TabIndex = 12;
            this.train_ID.TextChanged += new System.EventHandler(this.train_ID_TextChanged);
            // 
            // dep_station
            // 
            this.dep_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_station.Location = new System.Drawing.Point(662, 97);
            this.dep_station.Name = "dep_station";
            this.dep_station.Size = new System.Drawing.Size(187, 30);
            this.dep_station.TabIndex = 13;
            // 
            // dep_date
            // 
            this.dep_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_date.Location = new System.Drawing.Point(662, 143);
            this.dep_date.Name = "dep_date";
            this.dep_date.Size = new System.Drawing.Size(187, 30);
            this.dep_date.TabIndex = 14;
            // 
            // dep_time
            // 
            this.dep_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_time.Location = new System.Drawing.Point(662, 194);
            this.dep_time.Name = "dep_time";
            this.dep_time.Size = new System.Drawing.Size(187, 30);
            this.dep_time.TabIndex = 15;
            // 
            // arr_station
            // 
            this.arr_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_station.Location = new System.Drawing.Point(662, 244);
            this.arr_station.Name = "arr_station";
            this.arr_station.Size = new System.Drawing.Size(187, 30);
            this.arr_station.TabIndex = 16;
            // 
            // arr_date
            // 
            this.arr_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_date.Location = new System.Drawing.Point(662, 293);
            this.arr_date.Name = "arr_date";
            this.arr_date.Size = new System.Drawing.Size(187, 30);
            this.arr_date.TabIndex = 17;
            // 
            // arr_time
            // 
            this.arr_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_time.Location = new System.Drawing.Point(662, 351);
            this.arr_time.Name = "arr_time";
            this.arr_time.Size = new System.Drawing.Size(187, 30);
            this.arr_time.TabIndex = 18;
            // 
            // max_cap
            // 
            this.max_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_cap.Location = new System.Drawing.Point(662, 402);
            this.max_cap.Name = "max_cap";
            this.max_cap.Size = new System.Drawing.Size(187, 30);
            this.max_cap.TabIndex = 19;
            // 
            // avlbl_seats
            // 
            this.avlbl_seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avlbl_seats.Location = new System.Drawing.Point(662, 456);
            this.avlbl_seats.Name = "avlbl_seats";
            this.avlbl_seats.Size = new System.Drawing.Size(187, 30);
            this.avlbl_seats.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainBooking.Properties.Resources.icons8_subway_100;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(883, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avlbl_seats);
            this.Controls.Add(this.max_cap);
            this.Controls.Add(this.arr_time);
            this.Controls.Add(this.arr_date);
            this.Controls.Add(this.arr_station);
            this.Controls.Add(this.dep_time);
            this.Controls.Add(this.dep_date);
            this.Controls.Add(this.dep_station);
            this.Controls.Add(this.train_ID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Trip";
            this.Text = "Add_Trip";
            this.Load += new System.EventHandler(this.Add_Trip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox train_ID;
        private System.Windows.Forms.TextBox dep_station;
        private System.Windows.Forms.TextBox dep_date;
        private System.Windows.Forms.TextBox dep_time;
        private System.Windows.Forms.TextBox arr_station;
        private System.Windows.Forms.TextBox arr_date;
        private System.Windows.Forms.TextBox arr_time;
        private System.Windows.Forms.TextBox max_cap;
        private System.Windows.Forms.TextBox avlbl_seats;
        private System.Windows.Forms.Button button1;
    }
}