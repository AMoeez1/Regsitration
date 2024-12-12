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

namespace Regsitration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string md5Hash(string pass)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in data)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public bool verifyPassword(string enteredPass, string hashedPass)
        {
            string hashed = md5Hash(enteredPass);
            return hashed == hashedPass;
        }

        private void handleLogin_Click(object sender, EventArgs e)
        {
            string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=desktop;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(server);
            conn.Open();
            if (email.Text == "" && password.Text == "")
            {
                MessageBox.Show("Null Values Prohibited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Regex regex = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isValid = regex.IsMatch(email.Text);
            if (!isValid)
            {
                MessageBox.Show("Enter Valid Email");
                return;
            }
            string enteredPass = password.Text;
            string storedHash = md5Hash(enteredPass);
            bool isPasswordCorrect = verifyPassword(enteredPass, storedHash);
            string query = "SELECT * FROM myTbl WHERE email = @email";
            if(isPasswordCorrect)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email.Text);
                object result = cmd.ExecuteScalar();
                if(result != null)
                {
                    MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    email.Text = "";
                    password.Text = "";
                
                } else
                {
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
