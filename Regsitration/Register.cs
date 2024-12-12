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

namespace Regsitration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public string md5Hash(string pass)
        {
            using (MD5 md5 = MD5.Create()) {
                byte[] data = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in data)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
        private void handleRegister_Click(object sender, EventArgs e)
        {
            string server = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=desktop;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(server);
            conn.Open();
            if (name.Text == "" && email.Text == "" && password.Text == "")
            {
                MessageBox.Show("Null Values Prohibited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Regex regex = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isValid = regex.IsMatch(email.Text);
            if (!isValid)
            {
                MessageBox.Show("Enter Valid Email");
            }
            string query = "INSERT INTO myTbl(name, email, password) VALUES (@name, @email, @password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("email", email.Text);
            string pass = password.Text;
            string passText = md5Hash(pass);
            cmd.Parameters.AddWithValue("@password", passText);

            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
            {
                MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name.Text = "";
                email.Text = "";
                password.Text = "";
            } else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void redirectLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
