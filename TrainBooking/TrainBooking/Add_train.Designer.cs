namespace TrainBooking
{
    partial class Add_train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_train));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.train_name_lbl = new System.Windows.Forms.Label();
            this.departure_station_lbl = new System.Windows.Forms.Label();
            this.arrival_station_lbl = new System.Windows.Forms.Label();
            this.train_name_txt = new System.Windows.Forms.TextBox();
            this.dep_station_txt = new System.Windows.Forms.TextBox();
            this.arr_station_txt = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(230, 620);
            this.panel1.TabIndex = 0;
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
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButton1.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(471, 493);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(117, 60);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Add ";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // train_name_lbl
            // 
            this.train_name_lbl.AutoSize = true;
            this.train_name_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.train_name_lbl.ForeColor = System.Drawing.Color.White;
            this.train_name_lbl.Location = new System.Drawing.Point(287, 119);
            this.train_name_lbl.Name = "train_name_lbl";
            this.train_name_lbl.Size = new System.Drawing.Size(165, 40);
            this.train_name_lbl.TabIndex = 2;
            this.train_name_lbl.Text = "Train Name :";
            this.train_name_lbl.Click += new System.EventHandler(this.train_name_lbl_Click);
            // 
            // departure_station_lbl
            // 
            this.departure_station_lbl.AutoSize = true;
            this.departure_station_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.departure_station_lbl.ForeColor = System.Drawing.Color.White;
            this.departure_station_lbl.Location = new System.Drawing.Point(287, 223);
            this.departure_station_lbl.Name = "departure_station_lbl";
            this.departure_station_lbl.Size = new System.Drawing.Size(235, 40);
            this.departure_station_lbl.TabIndex = 3;
            this.departure_station_lbl.Text = "Departure Station :";
            this.departure_station_lbl.Click += new System.EventHandler(this.departure_station_lbl_Click);
            // 
            // arrival_station_lbl
            // 
            this.arrival_station_lbl.AutoSize = true;
            this.arrival_station_lbl.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.arrival_station_lbl.ForeColor = System.Drawing.Color.White;
            this.arrival_station_lbl.Location = new System.Drawing.Point(287, 332);
            this.arrival_station_lbl.Name = "arrival_station_lbl";
            this.arrival_station_lbl.Size = new System.Drawing.Size(198, 40);
            this.arrival_station_lbl.TabIndex = 4;
            this.arrival_station_lbl.Text = "Arrival Station :";
            this.arrival_station_lbl.Click += new System.EventHandler(this.arrival_station_lbl_Click);
            // 
            // train_name_txt
            // 
            this.train_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_name_txt.Location = new System.Drawing.Point(608, 127);
            this.train_name_txt.Name = "train_name_txt";
            this.train_name_txt.Size = new System.Drawing.Size(166, 30);
            this.train_name_txt.TabIndex = 5;
            // 
            // dep_station_txt
            // 
            this.dep_station_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_station_txt.Location = new System.Drawing.Point(608, 231);
            this.dep_station_txt.Name = "dep_station_txt";
            this.dep_station_txt.Size = new System.Drawing.Size(166, 30);
            this.dep_station_txt.TabIndex = 6;
            // 
            // arr_station_txt
            // 
            this.arr_station_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arr_station_txt.Location = new System.Drawing.Point(608, 332);
            this.arr_station_txt.Name = "arr_station_txt";
            this.arr_station_txt.Size = new System.Drawing.Size(166, 30);
            this.arr_station_txt.TabIndex = 7;
            this.arr_station_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Add_train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(874, 620);
            this.Controls.Add(this.arr_station_txt);
            this.Controls.Add(this.dep_station_txt);
            this.Controls.Add(this.train_name_txt);
            this.Controls.Add(this.arrival_station_lbl);
            this.Controls.Add(this.departure_station_lbl);
            this.Controls.Add(this.train_name_lbl);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(11, 131);
            this.Name = "Add_train";
            this.Text = "Add_train";
            this.Load += new System.EventHandler(this.Add_train_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label train_name_lbl;
        private System.Windows.Forms.Label departure_station_lbl;
        private System.Windows.Forms.Label arrival_station_lbl;
        private System.Windows.Forms.TextBox train_name_txt;
        private System.Windows.Forms.TextBox dep_station_txt;
        private System.Windows.Forms.TextBox arr_station_txt;
    }
}