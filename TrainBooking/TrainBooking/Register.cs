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
    public partial class Register : Form

    {

        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        static SqlConnection conection = new SqlConnection(coniction_st);

        public Register()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            conection.Open();
            string insertStatement = "INSERT INTO Person (First_Name, Last_Name, email , pass , user_type) VALUES (@Value1, @Value2, @Value3 , @Value4 , @Value5)";
            SqlCommand cmd = new SqlCommand(insertStatement, conection);
            cmd.Parameters.AddWithValue("@Value1",rgs_fn.Text);
            cmd.Parameters.AddWithValue("@Value2", rgs_ls.Text);
            cmd.Parameters.AddWithValue("@Value3", rgs_email.Text);
            cmd.Parameters.AddWithValue("@Value4", rgs_pass.Text);
            cmd.Parameters.AddWithValue("@Value5" , user_type.Text);
            cmd.ExecuteNonQuery();
            conection.Close();
            MessageBox.Show("Registered Successfully!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void back_to_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
