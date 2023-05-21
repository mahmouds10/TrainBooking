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
using System.Security.Cryptography.X509Certificates;

namespace TrainBooking
{
    public partial class TrainBooking : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        SqlConnection conection = new SqlConnection(coniction_st);

        public TrainBooking()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void TrainBooking_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable loadUserTable()
        {
            DataTable dt = new DataTable();
            string query = "select * from Person";
            conection.Open();
            SqlCommand cmd = new SqlCommand(query, conection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conection.Close();
            return dt;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Register registrationForm = new Register();
            registrationForm.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login_email.Text == "")
            {
                MessageBox.Show("Please enter email");
            }
            else if (login_pass.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else if (user_type_lbl.Text == "")
            {
                MessageBox.Show("Please choose login type");
            }
            else
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Person WHERE email = @email AND pass = @Pass and user_type = @user_type", conection);
                command.Parameters.AddWithValue("@email", login_email.Text);
                command.Parameters.AddWithValue("@pass", login_pass.Text);
                command.Parameters.AddWithValue("@user_type", user_type_cb.Text);
                string textBoxValue = login_email.Text;
                Update_Profile update_Profile = new Update_Profile();
                string newmail = update_Profile.new_email.Text;
                conection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                { 
                    if (user_type_cb.Text == "ADMIN")
                    {
                        MessageBox.Show("Welcome admin");
                        adminLogin aft = new adminLogin();
                        aft.Show();
                    }
                    else
                    {

                        MessageBox.Show("Welcome customer");
                        Customer customer = new Customer(textBoxValue ); 
                        customer.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Email or Password is not correct");
                }
                reader.Close();
                conection.Close();
            }
        }

        public string TextBoxValue
        {
            get { return login_email.Text; }
        }

        public void txt_email_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void user_type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_type_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
                
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(31, 30, 68);
            Register registrationForm = new Register();
            registrationForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
