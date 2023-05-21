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
    public partial class Unbook_trip : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Unbook_trip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(coniction_st))
            {
                string sql = "DELETE FROM Booking WHERE booking_ID = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", ID.Text);
                connection.Open();
                command.ExecuteNonQuery();
                SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Booking", connection);
                int rowCount = (int)countCommand.ExecuteScalar();
                SqlCommand reseedCommand = new SqlCommand($"DBCC CHECKIDENT ('Booking', RESEED, {rowCount})", connection);
                reseedCommand.ExecuteNonQuery();
                command.ExecuteNonQuery();
                string update = "UPDATE Trip SET available_seats = (max_capacity - (SELECT COUNT(*) FROM Booking WHERE trip_ID = @tid)) WHERE trip_ID = @tid;";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@tid", ID.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Unbooked successfully");
                this.Close();
            }
        }

        private void Unbook_trip_Load(object sender, EventArgs e)
        {

        }
    }
}
