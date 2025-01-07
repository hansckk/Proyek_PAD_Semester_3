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

namespace Proyek_PAD
{
    public partial class Form8 : Form
    {
        private string connectionString = "Server=localhost;Database=mcd_pad;Uid=root;Pwd=;";
        public Form8()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadMember();
        }

        private void LoadMember()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM customers";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // back
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO customers (nama_customer, nomor_telepon, email_customer, alamat_customer) " +
                                         "VALUES (@nama_customer, @nomor_telepon, @email_customer, @alamat_customer)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@nama_customer", textBox1.Text);
                        insertCommand.Parameters.AddWithValue("@nomor_telepon", textBox2.Text);
                        insertCommand.Parameters.AddWithValue("@email_customer", textBox3.Text);
                        insertCommand.Parameters.AddWithValue("@alamat_customer", textBox4.Text);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();

                            LoadMember();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Pastikan semua field diisi
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                    int idCustomer = Convert.ToInt32(selectedRow.Cells["id_customer"].Value);

                    string updateQuery = "UPDATE customers SET nama_customer = @nama_customer, nomor_telepon = @nomor_telepon, " +
                                         "email_customer = @email_customer, alamat_customer = @alamat_customer " +
                                         "WHERE id_customer = @id_customer";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@id_customer", idCustomer);
                        updateCommand.Parameters.AddWithValue("@nama_customer", textBox1.Text);
                        updateCommand.Parameters.AddWithValue("@nomor_telepon", textBox2.Text);
                        updateCommand.Parameters.AddWithValue("@email_customer", textBox3.Text);
                        updateCommand.Parameters.AddWithValue("@alamat_customer", textBox4.Text);

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMember();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                    int idCustomer = Convert.ToInt32(selectedRow.Cells["id_customer"].Value);

                    string deleteQuery = "DELETE FROM customers WHERE id_customer = @id_customer";
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id_customer", idCustomer);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMember();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["nama_customer"].Value?.ToString() ?? "";
                textBox2.Text = row.Cells["nomor_telepon"].Value?.ToString() ?? "";
                textBox3.Text = row.Cells["email_customer"].Value?.ToString() ?? "";
                textBox4.Text = row.Cells["alamat_customer"].Value?.ToString() ?? "";

               
            }
        }
    }
}
