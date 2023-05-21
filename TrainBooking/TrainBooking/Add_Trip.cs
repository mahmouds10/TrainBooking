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
    public partial class Add_Trip : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        static SqlConnection conection = new SqlConnection(coniction_st);
        public Add_Trip()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conection.Open();
            string insertStatement = "INSERT INTO Trip (train_ID, departure_station, departure_date,departure_time, arrival_station,arrival_date,arrival_time,max_capacity,available_seats) VALUES (@train_ID, @departure_station,@departure_date,@departure_time, @arrival_station , @arrival_date,@arrival_time,@max_capacity , @available_seats)";
            SqlCommand cmd = new SqlCommand(insertStatement, conection);
            cmd.Parameters.AddWithValue("@train_ID", train_ID.Text);
            cmd.Parameters.AddWithValue("@departure_station", dep_station.Text);
            cmd.Parameters.AddWithValue("@departure_date" , dep_date.Text);
            cmd.Parameters.AddWithValue("@departure_time" , dep_time.Text);
            cmd.Parameters.AddWithValue("@arrival_station", arr_station.Text);
            cmd.Parameters.AddWithValue("@arrival_date", arr_date.Text);
            cmd.Parameters.AddWithValue("@arrival_time", arr_time.Text);
            cmd.Parameters.AddWithValue("@max_capacity", max_cap.Text);
            cmd.Parameters.AddWithValue("@available_seats", avlbl_seats.Text);

            cmd.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show("Trip added Successfully!");
            this.Close();
        }

        private void Add_Trip_Load(object sender, EventArgs e)
        {

        }

        private void train_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
