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
    public partial class Update_Trip : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Update_Trip()
        {
            InitializeComponent();
        }

        private void Modify_Trip_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update_query = "update Trip set train_ID = @ID , departure_station = @ds , departure_Date = @dd , departure_time = @dt , arrival_station = @ars , arrival_date = @ad , arrival_time = @at , max_capacity = @max , available_seats = @av where trip_ID = @TID;";
            SqlCommand command = new SqlCommand(update_query, conection);
            command.Parameters.AddWithValue("@ID" , new_ID.Text);
            command.Parameters.AddWithValue("@ds", new_ds.Text);
            command.Parameters.AddWithValue("@dd" , new_dd.Text);
            command.Parameters.AddWithValue("@dt" , new_dt.Text);
            command.Parameters.AddWithValue("@ars" , new_ars.Text);
            command.Parameters.AddWithValue("@ad" , new_ard.Text);
            command.Parameters.AddWithValue("@at" , new_art.Text);
            command.Parameters.AddWithValue("@max" , new_max.Text);
            command.Parameters.AddWithValue("@av" , new_avl.Text);
            command.Parameters.AddWithValue("@TID" , trip_ID.Text);
            conection.Open();
            command.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show( "trip updated successfully.");
            this.Close();
        }
    }
}
