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
    public partial class Delete_profile : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Delete_profile()
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
                string sql = "DELETE FROM Person WHERE user_ID = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", ID.Text);
                connection.Open();
                command.ExecuteNonQuery();
                SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Person", connection);
                int rowCount = (int)countCommand.ExecuteScalar();
                SqlCommand reseedCommand = new SqlCommand($"DBCC CHECKIDENT ('Person', RESEED, {rowCount})", connection);
                reseedCommand.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User deleted successfully");
                Environment.Exit(0);
            }
        }

        private void Delete_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
