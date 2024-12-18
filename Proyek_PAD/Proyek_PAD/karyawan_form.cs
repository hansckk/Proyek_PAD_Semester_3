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
    public partial class karyawan_form : Form
    {
        private string connectionString = "Server=localhost;Database=mcd_pad;Uid=root;Pwd=;";

        public karyawan_form()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                  
                    string query = "SELECT * FROM karyawan";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e) // INSERT
        {
            try
            {
                if (numericUpDown1.Value < 17)
                {
                    MessageBox.Show("Umur minimal 17 tahun!", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaKasir = textBox2.Text.Trim();
                string sex = radioButton1.Checked ? "L" : (radioButton2.Checked ? "P" : null);
                int umur = (int)numericUpDown1.Value;
                string nomorTelepon = textBox3.Text.Trim();

                if (string.IsNullOrEmpty(namaKasir) || sex == null || string.IsNullOrEmpty(nomorTelepon))
                {
                    MessageBox.Show("Harap isi semua kolom yang wajib!", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string passwordKasir = namaKasir + "McD";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO karyawan (nama, sex, umur, nomor_telepon, password,role_id) 
                             VALUES (@nama, @sex, @umur, @nomor_telepon, @password,2)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nama", namaKasir);
                        command.Parameters.AddWithValue("@sex", sex);
                        command.Parameters.AddWithValue("@umur", umur);
                        command.Parameters.AddWithValue("@nomor_telepon", nomorTelepon);
                        command.Parameters.AddWithValue("@password", passwordKasir);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data kasir berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            numericUpDown1.Value = 17; 
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // UPDATE
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Pilih baris yang ingin diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idKasir = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_kasir"].Value);

                string namaKasir = textBox2.Text.Trim();
                string sex = radioButton1.Checked ? "L" : (radioButton2.Checked ? "P" : null);
                int umur = (int)numericUpDown1.Value;
                string nomorTelepon = textBox3.Text.Trim();

                if (string.IsNullOrEmpty(namaKasir) || sex == null || string.IsNullOrEmpty(nomorTelepon))
                {
                    MessageBox.Show("Harap isi semua kolom yang wajib!", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE karyawan SET nama = @nama, sex = @sex, umur = @umur, 
                             nomor_telepon = @nomor_telepon, password_kasir = @password WHERE crew_id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idKasir);
                        command.Parameters.AddWithValue("@nama", namaKasir);
                        command.Parameters.AddWithValue("@sex", sex);
                        command.Parameters.AddWithValue("@umur", umur);
                        command.Parameters.AddWithValue("@nomor_telepon", nomorTelepon);
                        command.Parameters.AddWithValue("@password", namaKasir + "McD"); 

                        command.ExecuteNonQuery();
                        MessageBox.Show("Data kasir berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // DELTE
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Pilih baris yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idKasir = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_kasir"].Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM kasir WHERE id_kasir = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idKasir);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data kasir berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataToDataGridView();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e) // CLEAR
        {
            ClearInput();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox2.Text = row.Cells["nama_kasir"].Value.ToString();
                string sex = row.Cells["sex"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(row.Cells["umur"].Value);
                textBox3.Text = row.Cells["nomor_telepon"].Value.ToString();

                if (sex == "L")
                    radioButton1.Checked = true;
                else if (sex == "P")
                    radioButton2.Checked = true;

                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;   
        }
    }
}