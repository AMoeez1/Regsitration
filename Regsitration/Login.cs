using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BCrypt.Net;

namespace Regsitration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void handleLogin_Click(object sender, EventArgs e)
        {
            string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=desktop;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(server);

            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(password.Text))
                {
                    MessageBox.Show("Email and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Regex regex = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!regex.IsMatch(email.Text))
                {
                    MessageBox.Show("Enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT password FROM myTbl WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email.Text);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string storedHash = result.ToString();
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password.Text, storedHash);

                    if (isPasswordCorrect)
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        email.Text = "";
                        password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void redirectLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 register = new Form1();
            register.Show();
            this.Hide();
        }
    }
}
