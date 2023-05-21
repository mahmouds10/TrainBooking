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
    public partial class Book_a_Trip : Form
    {
        private string _textBoxValue;
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        static SqlConnection conection = new SqlConnection(coniction_st);

        string user_ID = null;

        public Book_a_Trip(string textBoxValue)
        {
            InitializeComponent();
            _textBoxValue = textBoxValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conection.Open();

            using (SqlCommand command = new SqlCommand("SELECT user_ID FROM Person WHERE email = @Email", conection))
            {
                command.Parameters.AddWithValue("@Email", _textBoxValue);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    user_ID = result.ToString();
                }


            }



            string insertStatement = "insert into Booking(trip_ID , user_ID ,booking_time) values (@tid , @uid ,GETDATE());";
            string update = "UPDATE Trip SET available_seats = (max_capacity - (SELECT COUNT(*) FROM Booking WHERE trip_ID = @tid)) WHERE trip_ID = @tid;";
            SqlCommand cmd = new SqlCommand(insertStatement, conection);
            cmd.Parameters.AddWithValue("@tid", btrip_ID.Text );
            cmd.Parameters.AddWithValue("@uid", user_ID); 
            cmd.ExecuteNonQuery();
            SqlCommand updateq = new SqlCommand(update, conection);
            updateq.Parameters.AddWithValue("@tid", btrip_ID.Text);
            updateq.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show("Trip booked Successfully!");
            this.Close();
        }

        private void btrip_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Book_a_Trip_Load(object sender, EventArgs e)
        {

        }
    }
}
