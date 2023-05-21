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
    public partial class Update_Train : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Update_Train()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update_query = "update train set train_name = @train_name , departure_station = @ds , arrival_station = @ars where train_ID = @ID;";
            SqlCommand command = new SqlCommand(update_query, conection);
            command.Parameters.AddWithValue("@train_name", new_name.Text);
            command.Parameters.AddWithValue("@ds", new_ds.Text);
            command.Parameters.AddWithValue("@ars", new_ars.Text);
            command.Parameters.AddWithValue("@ID", ID.Text);
            conection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            conection.Close();
             MessageBox.Show(rowsAffected + " Train(s) updated successfully.");
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void new_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_ars_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
