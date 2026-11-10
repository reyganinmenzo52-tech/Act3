using MySql.Data.MySqlClient;

namespace Act3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Change these to your actual textbox names
            string email = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string confirm = textBox4.Text;

            if (email == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connStr = "server=localhost;user=root;password=volunteer123;database=VolunteerDB;";

            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO User (Email, Username, Password) VALUES (@email, @user, @pass)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registered successfully! Please log in.");

                    // Go back to the login form
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 LogIn = new Form1();

            LogIn.Show();

            this.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
