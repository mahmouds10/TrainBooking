using FontAwesome.Sharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainBooking
{
    public partial class Customer : Form
    {
        static string coniction_st = "Data Source=MAHMOUD;Initial Catalog=TrainBooking;Integrated Security=True ";
        static SqlConnection conection = new SqlConnection(coniction_st);
        public IconButton currentBtn;
        public Panel leftBoardBtn;
        private string _textBoxValue;


        public Customer(string textBoxValue )
        {
            InitializeComponent();
            _textBoxValue = textBoxValue;
 

            book_trip.Visible = false;
            modify_user.Visible = false;
            unbook.Visible = false;
            delet_acc.Visible = false;

            leftBoardBtn = new Panel();
            leftBoardBtn.Size = new Size(7, 245);
            Profile.Controls.Add(leftBoardBtn);
            trips_awf.Controls.Add(leftBoardBtn);
            _textBoxValue = textBoxValue;

        }
        public struct RGBColor
        {
            public static Color c1 = Color.FromArgb(172, 126, 241);
            public static Color c2 = Color.FromArgb(249, 118, 176);
        }
        public void activebtn(object senderBtn, Color clr)
        {
            if (senderBtn != null)
            {
                displayButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = clr;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = clr;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        public void displayButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
 
        private void delete_train_Click(object sender, EventArgs e)
        {

        }
 
        string user_ID = null;
        private string _newEmail = "";
        string ID = "";

        private void treain_awf_Click(object sender, EventArgs e)
        {
            book_trip.Visible = false;
            modify_user.Visible = true;
            unbook.Visible = false;
            delet_acc.Visible = true;
            activebtn(sender, RGBColor.c2);

            using (SqlCommand command = new SqlCommand("SELECT user_ID FROM Person WHERE email = @Email", conection))
            {
                conection.Open();
                command.Parameters.AddWithValue("@Email", _textBoxValue);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    user_ID = result.ToString();
                }
                conection.Close();

            }

             using (SqlConnection connection = new SqlConnection(coniction_st))
            {
                string query = "SELECT p.user_ID, p.First_Name, p.Last_Name, p.email, COALESCE(b.booking_ID, null) AS booking_ID, t.trip_ID, t.departure_station, t.arrival_station ,b.booking_time\r\nFROM Person p\r\nLEFT JOIN Booking b ON p.user_ID = b.user_ID\r\nLEFT JOIN Trip t ON b.trip_ID = t.trip_ID\r\n where p.user_ID = @id ;";
                string update = "UPDATE Trip SET available_seats = (max_capacity - (SELECT COUNT(*) FROM Booking WHERE trip_ID = @tid)) WHERE trip_ID = @tid;";
                using (SqlCommand selectcommand = new SqlCommand(query, connection))
                {
                    selectcommand.Parameters.AddWithValue("@email", _textBoxValue);
                    selectcommand.Parameters.AddWithValue("@id", user_ID);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectcommand);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    using (SqlCommand updateCommand = new SqlCommand(update, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@tid",ID );
                        updateCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }


        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modify_trip_Click(object sender, EventArgs e)
        {
            Update_Profile  update_Profile = new Update_Profile();  
            update_Profile.Show();

        }

        private void trips_awf_Click(object sender, EventArgs e)
        {
            book_trip.Visible = true;
            modify_user.Visible = false;
            unbook.Visible = true;
            delet_acc.Visible = false;   
            activebtn(sender, RGBColor.c2);
            DataGrid train = new DataGrid();
            string query = "select tr.trip_ID    ,tr.departure_station , tr.departure_date , tr.departure_time , tr.arrival_station , tr.arrival_date , tr.arrival_time , tr.available_seats\r\nfrom Trip tr;";
            using (SqlConnection connection = new SqlConnection(coniction_st))
            {
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    conection.Close();
                }
            }
        }

        private void delet_acc_Click(object sender, EventArgs e)
        {
            Delete_profile delete_Profile = new Delete_profile();   
            delete_Profile.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void book_his_Click(object sender, EventArgs e)
        {
          
        }

        private void unbook_Click(object sender, EventArgs e)
        {
            Unbook_trip unbook = new Unbook_trip(); 
            unbook.Show();

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Book_a_Trip book_A_Trip = new Book_a_Trip(_textBoxValue);
            book_A_Trip.Show();
            ID = book_A_Trip.btrip_ID.Text;
        }


        }
}
