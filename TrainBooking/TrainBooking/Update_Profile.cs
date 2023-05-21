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
    public partial class Update_Profile : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);
        public Update_Profile()
        {
            InitializeComponent();
        }
        public string New_Email
        {
            get { return new_email.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update_query = "update Person set First_Name = @Fn , Last_Name = @Ls , email = @email , pass = @ps where user_ID = @id;";
            SqlCommand command = new SqlCommand(update_query, conection);
            command.Parameters.AddWithValue("@Fn", new_fname.Text);
            command.Parameters.AddWithValue("@ls", new_lname.Text);
            command.Parameters.AddWithValue("@email", new_email.Text);
            command.Parameters.AddWithValue("@ps", new_pass.Text);
            command.Parameters.AddWithValue("@id", ID.Text);
            string newmail =new_email.Text;            
            conection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show("Updated successfully.");
            this.Close();
           
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
