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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Login
{
    public partial class UserLogin : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void ToLogin_Click(object sender, EventArgs e)//to registration form
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void UserLogin_Load(object sender, EventArgs e)//connects to database 
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Temp\SQL Login\MainDatabase.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //doesnt allow if username or password is empty
            if (Password.Text != string.Empty || Username.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + Username.Text + "' and password='" + Password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Homepage home = new Homepage();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
