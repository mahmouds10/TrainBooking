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
    public partial class Delete_Train : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Delete_Train()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(coniction_st))
            {
                string sql = "DELETE FROM train WHERE train_ID = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", ID.Text);
                connection.Open();
                command.ExecuteNonQuery();
                SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM train", connection);
                int rowCount = (int)countCommand.ExecuteScalar();
                SqlCommand reseedCommand = new SqlCommand($"DBCC CHECKIDENT ('train', RESEED, {rowCount})", connection);
                reseedCommand.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Train deleted successfully");
                this.Close();
            }
        }

        private void Delete_Train_Load(object sender, EventArgs e)
        {

        }
    }
}
