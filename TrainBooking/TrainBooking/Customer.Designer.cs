namespace TrainBooking
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unbook = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Profile = new FontAwesome.Sharp.IconButton();
            this.trips_awf = new FontAwesome.Sharp.IconButton();
            this.modify_user = new FontAwesome.Sharp.IconButton();
            this.delet_acc = new FontAwesome.Sharp.IconButton();
            this.book_trip = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(226, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 535);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.trips_awf);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 620);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // unbook
            // 
            this.unbook.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.unbook.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.unbook.IconColor = System.Drawing.Color.Black;
            this.unbook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.unbook.IconSize = 33;
            this.unbook.Location = new System.Drawing.Point(856, 547);
            this.unbook.Name = "unbook";
            this.unbook.Size = new System.Drawing.Size(277, 61);
            this.unbook.TabIndex = 12;
            this.unbook.Text = "Delete Book";
            this.unbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unbook.UseVisualStyleBackColor = true;
            this.unbook.Click += new System.EventHandler(this.unbook_Click);
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
            // Profile
            // 
            this.Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.Gainsboro;
            this.Profile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.Profile.IconColor = System.Drawing.Color.Gainsboro;
            this.Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Profile.IconSize = 36;
            this.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.Location = new System.Drawing.Point(0, 140);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Profile.Size = new System.Drawing.Size(220, 245);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Profile";
            this.Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.treain_awf_Click);
            // 
            // trips_awf
            // 
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
            this.trips_awf.Click += new System.EventHandler(this.trips_awf_Click);
            // 
            // modify_user
            // 
            this.modify_user.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.modify_user.ForeColor = System.Drawing.Color.Black;
            this.modify_user.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.modify_user.IconColor = System.Drawing.Color.Black;
            this.modify_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modify_user.IconSize = 33;
            this.modify_user.Location = new System.Drawing.Point(376, 547);
            this.modify_user.Name = "modify_user";
            this.modify_user.Size = new System.Drawing.Size(253, 61);
            this.modify_user.TabIndex = 11;
            this.modify_user.Text = "Modify Data";
            this.modify_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modify_user.UseVisualStyleBackColor = true;
            this.modify_user.Click += new System.EventHandler(this.modify_trip_Click);
            // 
            // delet_acc
            // 
            this.delet_acc.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.delet_acc.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delet_acc.IconColor = System.Drawing.Color.Black;
            this.delet_acc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delet_acc.IconSize = 33;
            this.delet_acc.Location = new System.Drawing.Point(856, 547);
            this.delet_acc.Name = "delet_acc";
            this.delet_acc.Size = new System.Drawing.Size(277, 61);
            this.delet_acc.TabIndex = 12;
            this.delet_acc.Text = "Delete Account";
            this.delet_acc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delet_acc.UseVisualStyleBackColor = true;
            this.delet_acc.Click += new System.EventHandler(this.delet_acc_Click);
            // 
            // book_trip
            // 
            this.book_trip.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.book_trip.ForeColor = System.Drawing.Color.Black;
            this.book_trip.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.book_trip.IconColor = System.Drawing.Color.Black;
            this.book_trip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.book_trip.IconSize = 33;
            this.book_trip.Location = new System.Drawing.Point(376, 547);
            this.book_trip.Name = "book_trip";
            this.book_trip.Size = new System.Drawing.Size(253, 61);
            this.book_trip.TabIndex = 13;
            this.book_trip.Text = "Book Trip";
            this.book_trip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_trip.UseVisualStyleBackColor = true;
            this.book_trip.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1282, 620);
            this.Controls.Add(this.book_trip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modify_user);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unbook);
            this.Controls.Add(this.delet_acc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton trips_awf;
        private FontAwesome.Sharp.IconButton Profile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton modify_user;
        private FontAwesome.Sharp.IconButton delet_acc;
        private FontAwesome.Sharp.IconButton unbook;
        private FontAwesome.Sharp.IconButton book_trip;
    }
}