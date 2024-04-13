using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineShop {
    public partial class AdminForm : Form {
        private MySqlConnection con;
        private string connstring = "server=localhost;user=root;password=admin;database=online_shop";

        public AdminForm() {
            InitializeComponent();
            this.Text = "Main form";
            con = new MySqlConnection(connstring);
            FillComboBox();
        }

        private void OpenConnection() {
            if (con.State == ConnectionState.Closed) {
                con.Open();
            }
        }

        private void CloseConnection() {
            if (con.State == ConnectionState.Open) {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string insertQuery = "INSERT INTO products (Name, Weight, Price, SupplierId, Type) VALUES (@Name, @Weight, @Price, @SupplierId, @Type)";
            string selectQuery = "SELECT SupplierId FROM suppliers WHERE FullName = @FullName";
            int supplierID = FetchSupplierId(selectQuery, comboBox1.Text);
            if (supplierID == 0) {
                MessageBox.Show("Постачальника не знайдено");
                return;
            }

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con)) {
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Weight", textBox2.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.Parameters.AddWithValue("@SupplierId", supplierID);
                cmd.Parameters.AddWithValue("@Type", comboBox2.Text);

                ExecuteNonQuery(cmd);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private int FetchSupplierId(string query, string fullName) {
            using (MySqlCommand cmd = new MySqlCommand(query, con)) {
                cmd.Parameters.AddWithValue("@FullName", fullName);
                OpenConnection();
                object result = cmd.ExecuteScalar();
                CloseConnection();
                if (result != null) {
                    return Convert.ToInt32(result);
                }
            }
            return 0;
        }

        private void ExecuteNonQuery(MySqlCommand cmd) {
            try {
                OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Добавлено");
            }
            catch (MySqlException ex) {
                MessageBox.Show("MySQL Error: " + ex.Number + " - " + ex.Message);
            }
            finally {
                CloseConnection();
            }
        }

        private void FillComboBox() {
            string query = "SELECT FullName FROM suppliers";
            using (MySqlCommand cmd = new MySqlCommand(query, con)) {
                OpenConnection();
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        comboBox1.Items.Add(reader["FullName"].ToString());
                    }
                }
                CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            string insertQuery = "INSERT INTO suppliers (FullName, Address, PhoneNumber) VALUES (@FullName, @Address, @PhoneNumber)";

            using (MySqlCommand cmd = new MySqlCommand(insertQuery, con)) {
                cmd.Parameters.AddWithValue("@FullName", textBox4.Text);
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text);
                ExecuteNonQuery(cmd);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
