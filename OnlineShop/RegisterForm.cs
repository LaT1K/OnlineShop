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
    public partial class RegisterForm : Form {
        private MySqlConnection con = null;
        private string connstring = null;
        public RegisterForm() {
            InitializeComponent();
            this.Text = "Registration";
            connstring = "server=localhost;user=root;password=admin;database=online_shop";
            con = new MySqlConnection(connstring);
        }

        private void RegisterForm_Load(object sender, EventArgs e) {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            registerUser();
        }
        private bool doesAlreadyExist(string login) {
            if(con.State != ConnectionState.Open)
                con.Open();
            string queryString = "SELECT COUNT(*) FROM customers WHERE login = @login";
            using(MySqlCommand cmd = new MySqlCommand(queryString, con)) {
                cmd.Parameters.AddWithValue("@login", textBox1.Text);
                int existringUserCount = Convert.ToInt32(cmd.ExecuteScalar());
                if(existringUserCount > 0) {
                    MessageBox.Show("The user already exists");
                    return true;
                }
                else
                    return false;
            }
            
        }
        private void registerUser() {
            string queryString = "INSERT INTO customers(login, password) VALUES (@login, @password)";
            if(!doesAlreadyExist(textBox1.Text) && textBox2.Text == textBox3.Text) {
                using (MySqlCommand cmd = new MySqlCommand(queryString, con)) {
                    cmd.Parameters.AddWithValue("@login", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox3.Text);

                    try {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You were succesfully registered");
                    }
                    catch(MySqlException ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e) {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
