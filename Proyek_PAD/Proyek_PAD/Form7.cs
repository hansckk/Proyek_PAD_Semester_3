﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace Proyek_PAD
{
    //krng beberapa wkwk
    public partial class Form7 : Form
    {
        public List<orderedItem> orderedItems { get; set; }
        int discountId;
        int transId;
        public Form7()
        {
            transId = 0;
            discountId = 0;
            InitializeComponent();
            panel1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;

        }

        public void updateOrderList()
        {
            listBox2.Items.Clear();
            foreach (var item in orderedItems)
            {
                listBox2.Items.Add(new listBoxItem
                {
                    displayText = item.ToString(),
                    menuId = item.MenuItem.Id,
                    quantity = item.Quantity
                });
            }
        }

        private class listBoxItem
        {
            public string displayText { get; set; }
            public string menuId { get; set; }
            public int quantity { get; set; }

            public override string ToString()
            {
                return displayText;
            }


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            loadExtraCharge();
            LoadPaymentMethods1();
        }

        private void loadExtraCharge()
        {
            comboBox3.Items.Clear();
            try
            {
                Connection.open();
                string query = "SELECT * FROM extra_charge";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "extra_name";
                comboBox3.ValueMember = "extra_charge_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }

        private void loadPayment2()
        {
            comboBox2.DataSource = null;
            try
            {
                Connection.open();

                string query = "SELECT * FROM payment_method";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "nama_payment";
                comboBox2.ValueMember = "payment_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment methods: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }
        private void LoadPaymentMethods1()
        {
            comboBox1.DataSource = null;
            try
            {
                Connection.open();

                string query = "SELECT * FROM payment_method";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nama_payment";
                comboBox1.ValueMember = "payment_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment methods: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hapus inputan kecuali textBox2
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void insertMenu()
        {
            try
            {
                Connection.open();
                string query = "INSERT INTO transaksi_details(menu_id,transaksi_id) VALUES (@menu_id,@trans_id)";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                foreach (listBoxItem item in listBox2.Items)
                {
                    for (int i = 0; i < item.quantity; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@menu_id",item.menuId);
                        cmd.Parameters.AddWithValue("@trans_id", transId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }

        private void insertPaymentMethod()
        {
            try
            {
                Connection.open();
                string query = "INSERT INTO payment_trans(transaksi_id,payment_method,total) VALUES (@trans_id,@payment_method,@total)";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                cmd.Parameters.AddWithValue("@payment_method",comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@total", (int)numericUpDown1.Value);
                cmd.ExecuteNonQuery();
                if (radioButton1.Checked)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@trans_id", transId);
                    cmd.Parameters.AddWithValue("@payment_method",comboBox3.SelectedValue);
                    cmd.Parameters.AddWithValue("@total", (int)numericUpDown2.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        private void insertExtraCharge()
        {
            if(listBox1.Items.Count > 0)
            {
                try
                {
                    Connection.open();
                    string query = "INSERT INTO extra_charge_trans (transaksi_id, extra_charge_id) VALUES (@trans_id, @extra_charge_id)";
                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    foreach (extraCharge item in listBox1.Items)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@trans_id", transId);
                        cmd.Parameters.AddWithValue("@extra_charge_id", item.id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
        }
        private void insertTransaksi()
        {
            try
            {
                Connection.open();
                if (discountId > 0)
                {
                    string query = "INSERT INTO transaksi(status,diskon_id) VALUES ('pending', @diskon_id)";
                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("@diskon_id", discountId);
                    cmd.ExecuteNonQuery();
                    transId = (int)cmd.LastInsertedId;

                }
                else
                {
                    string query = "INSERT INTO transaksi (STATUS) VALUES ('pending')";
                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    cmd.ExecuteNonQuery();
                    transId = (int)cmd.LastInsertedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            insertTransaksi();
            insertExtraCharge();
            insertMenu();
            insertPaymentMethod();
            MessageBox.Show("Order Sukses!");     
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            loadPayment2();
            numericUpDown2.Visible = true;
            label12.Visible = true;
            comboBox2.Visible = true;
            label6.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
            numericUpDown2.Visible = false;
            label12.Visible = false;
            comboBox2.Visible = false;
            label6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.open();
                string query = "SELECT * FROM diskon WHERE diskon_kode = @kode";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@kode", textBox3.Text);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    textBox3.Text = "";
                    label8.Visible = true;
                    discountId = Convert.ToInt32(r["diskon_id"]);
                    string diskonNama = r["diskon_name"].ToString();
                    label8.Text = $"Discount: {diskonNama}";
                }
                else
                {
                    MessageBox.Show("Discount Not Found");
                    label8.Text = "Discount:";
                    label8.Visible = false;
                    textBox3.Text = "";
                    discountId = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        public class extraCharge
        {
            public int id { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return name;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBox3.SelectedItem;
                extraCharge ex = new extraCharge
                {
                    id = Convert.ToInt32(drv["extra_charge_id"]),
                    name = drv["extra_name"].ToString()
                };
                listBox1.Items.Add(ex);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkMember();
        }
        private void checkMember()
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int inputId)) // Cek apakah input adalah angka
            {
                panel1.Visible = false; // Sembunyikan panel jika input bukan angka
                return;
            }

            try
            {
                Connection.open();
                string query = "SELECT COUNT(*) FROM customers WHERE id_customer = @id_customer";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@id_customer", inputId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    panel1.Visible = true; // Tampilkan panel jika id_customer ditemukan
                }
                else
                {
                    panel1.Visible = false; // Sembunyikan panel jika id_customer tidak ditemukan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking customer ID: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }

    }
}
