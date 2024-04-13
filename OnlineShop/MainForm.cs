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
    public partial class MainForm : Form {
        private MySqlConnection con = null;
        private string connstring = null;
        public MainForm() {
            InitializeComponent();
            this.Text = "Main form";
            connstring = "server=localhost;user=root;password=admin;database=online_shop";
            con = new MySqlConnection(connstring);
        }

        private void всіТовариToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM products";
            fillDataGridView(query);
        }
        private void овочіToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM products WHERE Type = \"Vegetable\"";
            fillDataGridView(query);
        }
        private void фруктиToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM products WHERE Type = \"Fruit\"";
            fillDataGridView(query);
        }

        private void fillDataGridView(string query) {
            using (MySqlConnection connection = new MySqlConnection(connstring)) {
                try {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e) {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM suppliers";
            fillDataGridView(query);
        }
    }
}
