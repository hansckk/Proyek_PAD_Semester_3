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
        public Form8()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                Connection.open();

                string query = "SELECT * FROM menu";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }


        private void button1_Click(object sender, EventArgs e) // INSERT
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Pastikan semua field diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal hargaMenu) || hargaMenu <= 0)
            {
                MessageBox.Show("Harga harus berupa angka yang valid dan lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericUpDown1.Value;
            if (quantity < 1)
            {
                MessageBox.Show("Quantity minimal adalah 1!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kategori = comboBox1.SelectedItem.ToString();
            string idMenu = GenerateIdMenu(kategori);

            try
            {
                Connection.open();
                string query = "INSERT INTO menu (id_menu, nama_menu, harga_menu, quantity, kategori) " +
                               "VALUES (@id_menu, @nama_menu, @harga_menu, @quantity, @kategori)";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@id_menu", idMenu);
                cmd.Parameters.AddWithValue("@nama_menu", textBox1.Text);
                cmd.Parameters.AddWithValue("@harga_menu", hargaMenu);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@kategori", kategori);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }
        }

        private string GenerateIdMenu(string kategori)
        {
            string prefix = "";
            switch (kategori)
            {
                case "Makanan":
                    prefix = "MAKAN";
                    break;
                case "Minuman":
                    prefix = "MINUM";
                    break;
                case "Snack":
                    prefix = "SNACK";
                    break;
                case "Lainnya":
                    prefix = "LAIN";
                    break;
            }

            string query = $"SELECT id_menu FROM menu WHERE id_menu LIKE '{prefix}%' ORDER BY id_menu DESC LIMIT 1";

            string lastId = "";
            try
            {
                Connection.open(); 
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);

                object result = cmd.ExecuteScalar();
                lastId = result != null ? result.ToString() : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengambil ID terakhir: " + ex.Message);
            }
            finally
            {
                Connection.close();
            }

            int nextNumber = 1;
            if (!string.IsNullOrEmpty(lastId))
            {
                string numberPart = lastId.Substring(prefix.Length);
                if (int.TryParse(numberPart, out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }

            return $"{prefix}{nextNumber:D3}";
        }




        private void button2_Click(object sender, EventArgs e) // UPDATE
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Pastikan semua field diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal hargaMenu) || hargaMenu <= 0)
            {
                MessageBox.Show("Harga harus berupa angka yang valid dan lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericUpDown1.Value;
            if (quantity < 1)
            {
                MessageBox.Show("Quantity minimal adalah 1!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kategori = comboBox1.SelectedItem.ToString();
            string idMenu = GenerateIdMenu(kategori);

            if (dataGridView1.CurrentRow != null)
            {
                string oldIdMenu = dataGridView1.CurrentRow.Cells["id_menu"].Value.ToString();

                try
                {
                    Connection.open();
                    string query = "UPDATE menu SET id_menu = @id_menu, nama_menu = @nama_menu, harga_menu = @harga_menu, " +
                                   "quantity = @quantity, kategori = @kategori WHERE id_menu = @oldIdMenu";

                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("@id_menu", idMenu); 
                    cmd.Parameters.AddWithValue("@nama_menu", textBox1.Text);
                    cmd.Parameters.AddWithValue("@harga_menu", hargaMenu);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@oldIdMenu", oldIdMenu);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connection.close();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diupdate dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {
            if (dataGridView1.CurrentRow != null)
            {
                string idMenu = dataGridView1.CurrentRow.Cells["id_menu"].Value.ToString();

                DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus data dengan ID: {idMenu}?",
                                                     "Konfirmasi Hapus",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Connection.open();
                        string query = "DELETE FROM menu WHERE id_menu = @id_menu";

                        MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                        cmd.Parameters.AddWithValue("@id_menu", idMenu);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connection.close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e) // CLEAR
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 1; 
            comboBox1.SelectedIndex = -1; 
            textBox1.Focus();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["nama_menu"].Value.ToString();
                textBox2.Text = row.Cells["harga_menu"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(row.Cells["quantity"].Value);
                comboBox1.SelectedItem = row.Cells["kategori"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
