using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace TrainBooking
{
    public partial class adminLogin : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public IconButton currentBtn;
        public Panel leftBoardBtn;
        public adminLogin()
        {
            InitializeComponent();
            add_train.Visible= false;
            modify_train.Visible= false;
            delete_train.Visible= false;
            add_trip.Visible= false;
            modify_trip.Visible= false;
            delet_trip.Visible= false;
            

            leftBoardBtn = new Panel();
            leftBoardBtn.Size = new Size(7, 245);
            treain_awf.Controls.Add(leftBoardBtn);
            trips_awf.Controls.Add(leftBoardBtn);
        }
        public struct RGBColor
        {
            public static Color c1 = Color.FromArgb(172, 126, 241);
            public static Color c2 = Color.FromArgb(249, 118, 176);
        }

        public void activebtn(object senderBtn, Color clr)
        {
            if (senderBtn != null)
            {
                displayButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = clr;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = clr;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        public void displayButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            add_train.Visible = false;
            modify_train.Visible = false;
            delete_train.Visible = false;
            add_trip.Visible = true;
            modify_trip.Visible = true;
            delet_trip.Visible = true;
            activebtn(sender, RGBColor.c2);
            DataGrid train = new DataGrid();
            string query = "Select * from Trip";
            using (SqlConnection connection = new SqlConnection(coniction_st))
            {
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    conection.Close();
                }
            }
        }

        private void treain_awf_Click(object sender, EventArgs e)
        {
            add_train.Visible = true;
            modify_train.Visible = true;
            delete_train.Visible = true;
            add_trip.Visible = false;
            modify_trip.Visible = false;
            delet_trip.Visible = false;
            activebtn(sender, RGBColor.c1);
            DataGrid train = new DataGrid();
            string query = "SELECT t.*, COALESCE(tr.Trip_ID, null) AS trip_ID\r\nFROM train t\r\nLEFT JOIN Trip tr ON t.train_ID = tr.train_ID;";
            {
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    conection.Close();
                }
            }
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void modify_train_Click(object sender, EventArgs e)
        {
            Update_Train update_Train = new Update_Train();
            update_Train.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Delete_Trip delete_Trip = new Delete_Trip();        
            delete_Trip.Show();
        }

        private void add_train_Click(object sender, EventArgs e)
        {
            Add_train add_Train = new Add_train();
            add_Train.Show();
        }

        private void add_trip_Click(object sender, EventArgs e)
        {
            Add_Trip add_Trip = new Add_Trip();
            add_Trip.Show();
        }

        private void modify_trip_Click(object sender, EventArgs e)
        {
            Update_Trip modify_Trip = new Update_Trip();
            modify_Trip.Show();

        }

        private void delete_train_Click(object sender, EventArgs e)
        {
            Delete_Train delete = new Delete_Train();
            delete.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
