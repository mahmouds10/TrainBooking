namespace TrainBooking
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.trips_awf = new FontAwesome.Sharp.IconButton();
            this.treain_awf = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.add_trip = new FontAwesome.Sharp.IconButton();
            this.modify_trip = new FontAwesome.Sharp.IconButton();
            this.delet_trip = new FontAwesome.Sharp.IconButton();
            this.add_train = new FontAwesome.Sharp.IconButton();
            this.modify_train = new FontAwesome.Sharp.IconButton();
            this.delete_train = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.trips_awf);
            this.panel1.Controls.Add(this.treain_awf);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 620);
            this.panel1.TabIndex = 0;
            // 
            // trips_awf
            // 
            this.trips_awf.Dock = System.Windows.Forms.DockStyle.Top;
            this.trips_awf.FlatAppearance.BorderSize = 0;
            this.trips_awf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trips_awf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trips_awf.ForeColor = System.Drawing.Color.Gainsboro;
            this.trips_awf.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.trips_awf.IconColor = System.Drawing.Color.Gainsboro;
            this.trips_awf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.trips_awf.IconSize = 36;
            this.trips_awf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trips_awf.Location = new System.Drawing.Point(0, 385);
            this.trips_awf.Name = "trips_awf";
            this.trips_awf.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.trips_awf.Size = new System.Drawing.Size(220, 230);
            this.trips_awf.TabIndex = 5;
            this.trips_awf.Text = "Trips";
            this.trips_awf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.trips_awf.UseVisualStyleBackColor = true;
            this.trips_awf.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // treain_awf
            // 
            this.treain_awf.Dock = System.Windows.Forms.DockStyle.Top;
            this.treain_awf.FlatAppearance.BorderSize = 0;
            this.treain_awf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treain_awf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treain_awf.ForeColor = System.Drawing.Color.Gainsboro;
            this.treain_awf.IconChar = FontAwesome.Sharp.IconChar.Train;
            this.treain_awf.IconColor = System.Drawing.Color.Gainsboro;
            this.treain_awf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.treain_awf.IconSize = 36;
            this.treain_awf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.treain_awf.Location = new System.Drawing.Point(0, 140);
            this.treain_awf.Name = "treain_awf";
            this.treain_awf.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.treain_awf.Size = new System.Drawing.Size(220, 245);
            this.treain_awf.TabIndex = 1;
            this.treain_awf.Text = "Trains";
            this.treain_awf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.treain_awf.UseVisualStyleBackColor = true;
            this.treain_awf.Click += new System.EventHandler(this.treain_awf_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "GO FASTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainBooking.Properties.Resources.icons8_subway_100;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(220, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 539);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // add_trip
            // 
            this.add_trip.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.add_trip.ForeColor = System.Drawing.Color.Black;
            this.add_trip.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.add_trip.IconColor = System.Drawing.Color.Black;
            this.add_trip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_trip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_trip.Location = new System.Drawing.Point(347, 547);
            this.add_trip.Name = "add_trip";
            this.add_trip.Size = new System.Drawing.Size(167, 68);
            this.add_trip.TabIndex = 4;
            this.add_trip.Text = "Add Trip";
            this.add_trip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_trip.UseVisualStyleBackColor = true;
            this.add_trip.Click += new System.EventHandler(this.add_trip_Click);
            // 
            // modify_trip
            // 
            this.modify_trip.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.modify_trip.ForeColor = System.Drawing.Color.Black;
            this.modify_trip.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modify_trip.IconColor = System.Drawing.Color.Black;
            this.modify_trip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modify_trip.Location = new System.Drawing.Point(673, 543);
            this.modify_trip.Name = "modify_trip";
            this.modify_trip.Size = new System.Drawing.Size(194, 74);
            this.modify_trip.TabIndex = 3;
            this.modify_trip.Text = "Modify Trip";
            this.modify_trip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modify_trip.UseVisualStyleBackColor = true;
            this.modify_trip.Click += new System.EventHandler(this.modify_trip_Click);
            // 
            // delet_trip
            // 
            this.delet_trip.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.delet_trip.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delet_trip.IconColor = System.Drawing.Color.Black;
            this.delet_trip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delet_trip.Location = new System.Drawing.Point(1031, 544);
            this.delet_trip.Name = "delet_trip";
            this.delet_trip.Size = new System.Drawing.Size(174, 70);
            this.delet_trip.TabIndex = 6;
            this.delet_trip.Text = "Delete Trip";
            this.delet_trip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delet_trip.UseVisualStyleBackColor = true;
            this.delet_trip.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // add_train
            // 
            this.add_train.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.add_train.ForeColor = System.Drawing.Color.Black;
            this.add_train.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.add_train.IconColor = System.Drawing.Color.Black;
            this.add_train.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_train.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_train.Location = new System.Drawing.Point(347, 547);
            this.add_train.Name = "add_train";
            this.add_train.Size = new System.Drawing.Size(167, 68);
            this.add_train.TabIndex = 6;
            this.add_train.Text = "Add Train";
            this.add_train.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_train.UseVisualStyleBackColor = true;
            this.add_train.Click += new System.EventHandler(this.add_train_Click);
            // 
            // modify_train
            // 
            this.modify_train.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.modify_train.ForeColor = System.Drawing.Color.Black;
            this.modify_train.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modify_train.IconColor = System.Drawing.Color.Black;
            this.modify_train.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modify_train.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modify_train.Location = new System.Drawing.Point(673, 543);
            this.modify_train.Name = "modify_train";
            this.modify_train.Size = new System.Drawing.Size(194, 74);
            this.modify_train.TabIndex = 7;
            this.modify_train.Text = "Modify Train";
            this.modify_train.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modify_train.UseVisualStyleBackColor = true;
            this.modify_train.Click += new System.EventHandler(this.modify_train_Click);
            // 
            // delete_train
            // 
            this.delete_train.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.delete_train.ForeColor = System.Drawing.Color.Black;
            this.delete_train.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delete_train.IconColor = System.Drawing.Color.Black;
            this.delete_train.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete_train.Location = new System.Drawing.Point(1031, 545);
            this.delete_train.Name = "delete_train";
            this.delete_train.Size = new System.Drawing.Size(174, 69);
            this.delete_train.TabIndex = 8;
            this.delete_train.Text = "Delete Train";
            this.delete_train.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_train.UseVisualStyleBackColor = true;
            this.delete_train.Click += new System.EventHandler(this.delete_train_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1282, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_trip);
            this.Controls.Add(this.modify_trip);
            this.Controls.Add(this.delet_trip);
            this.Controls.Add(this.add_train);
            this.Controls.Add(this.modify_train);
            this.Controls.Add(this.delete_train);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminLogin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton treain_awf;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton trips_awf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton modify_train;
        private FontAwesome.Sharp.IconButton delete_train;
        private FontAwesome.Sharp.IconButton add_train;
        private FontAwesome.Sharp.IconButton add_trip;
        private FontAwesome.Sharp.IconButton modify_trip;
        private FontAwesome.Sharp.IconButton delet_trip;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}