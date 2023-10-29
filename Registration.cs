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

namespace SQL_Login
{
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //database connection
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Temp\SQL Login\MainDatabase.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//hides current form registration
            UserLogin login = new UserLogin();//creates object of the login page
            login.ShowDialog();//shows login form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if the user has inputted any values if not error
            if (Password.Text != string.Empty || Password.Text != string.Empty || Username.Text != string.Empty)
            {
                if (Password.Text == Password.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + Username.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else//creates username and password and adds to database
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert INTO LoginTable(username,password) values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("@username", Username.Text);
                        cmd.Parameters.AddWithValue("@password", Password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
