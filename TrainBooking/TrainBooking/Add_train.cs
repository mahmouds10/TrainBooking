using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class Add_train : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        static SqlConnection conection = new SqlConnection(coniction_st);
        public Add_train()
        {
            InitializeComponent();
        }

        private void login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void train_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void departure_station_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrival_station_lbl_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            conection.Open();
            string insertStatement = "INSERT INTO train (train_name, departure_station, arrival_station) VALUES (@train_name, @departure_station, @arrival_station)";
            SqlCommand cmd = new SqlCommand(insertStatement, conection);
            cmd.Parameters.AddWithValue("@train_name", train_name_txt.Text);
            cmd.Parameters.AddWithValue("@departure_station", dep_station_txt.Text);
            cmd.Parameters.AddWithValue("@arrival_station", arr_station_txt.Text);

            cmd.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show("Train added Successfully!");
            this.Close();
        }

        private void Add_train_Load(object sender, EventArgs e)
        {

        }
    }
}
