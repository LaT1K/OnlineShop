using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace OnlineShop {
    public partial class LoginForm : Form {
        private MySqlConnection con = null;
        private string connstring = null;
        public LoginForm() {
            InitializeComponent();
            this.Text = "Logging";
            connstring = "server=localhost;user=root;password=admin;database=online_shop";
            con = new MySqlConnection(connstring);
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(doesUserExist(textBox1.Text, textBox2.Text)) {
                MainForm mainFrom = new MainForm();
                this.Hide();
                mainFrom.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("User does not exist");
            }
        }

        private bool doesUserExist(string login, string password) {
            if (con.State != ConnectionState.Open)
                con.Open();
            string queryString = "SELECT COUNT(*) FROM customers WHERE login = @login AND password = @password";
            using (MySqlCommand cmd = new MySqlCommand(queryString, con)) {
                cmd.Parameters.AddWithValue("@login", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                int existringUserCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (existringUserCount > 0) {
                    return true;
                }
                else
                    return false;
            }

        }

        private void label6_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
