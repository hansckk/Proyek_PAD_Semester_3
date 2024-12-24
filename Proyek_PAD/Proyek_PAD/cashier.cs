﻿using System;
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
    public partial class cashier : Form
    {
        MySqlConnection con;
        string query;
        string worker;
        string[] food;
        List<image> menuImg;
        public cashier(string u)
        {
            menuImg = new List<image>();
            food = new string[3];
            food[0] = "MAKAN";
            food[1] = "MINUM";
            food[2] = "SNACK";
            worker = u;
            query = "";
            con = new MySqlConnection("Server=localhost;Database=mcd_pad;User Id=root;Password=;");
            InitializeComponent();
        }

        //ini buat nambah number dek textbox1
        // test
        private void numberButtonClick(string num)
        {
            foreach (var f in food)
            {
                if (cashierTextBox.Text.Contains(f))
                {
                    cashierTextBox.Text += num;
                    break;
                }
            }  
        }

        private void clearDisplay()
        {
            displayDataGridView.Columns.Clear();
            displayDataGridView.Rows.Clear();
        }

        private void showDisplay()
        {
            clearDisplay();
            displayDataGridView.ColumnCount = 2;
            displayDataGridView.Columns[0].HeaderText = "Menu Name";
            displayDataGridView.Columns[1].HeaderText = "Quantity";
            DataGridViewButtonColumn btn_column_add = new DataGridViewButtonColumn();
            btn_column_add.HeaderText = "Add";
            btn_column_add.Text = "Add";
            btn_column_add.UseColumnTextForButtonValue = true;
            displayDataGridView.Columns.Add(btn_column_add);
            DataGridViewButtonColumn btn_column_remove = new DataGridViewButtonColumn();
            btn_column_remove.HeaderText = "Remove";
            btn_column_remove.Text = "Remove";
            btn_column_remove.UseColumnTextForButtonValue = true;
            displayDataGridView.Columns.Add(btn_column_remove);
            DataGridViewButtonColumn btn_column_clear = new DataGridViewButtonColumn();
            btn_column_clear.HeaderText = "Clear";
            btn_column_clear.Text = "Clear";
            btn_column_clear.UseColumnTextForButtonValue = true;
            displayDataGridView.Columns.Add(btn_column_clear);
        }

        //buat jam ini
        private void timer1_Tick(object sender, EventArgs e)
        {
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
        }

        private void showTotal()
        {
            totalPanel.Visible = true;
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            workerLabel.Text = "Welcome, " + worker;
            menuDataGridView.Visible = false;
            totalPanel.Visible = false;
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
            time.Start();
        }
        private void clearText()
        {
            cashierTextBox.Text = "";
        }

        private void buttonNo1_Click(object sender, EventArgs e)
        {
            numberButtonClick("1");
        }

        private void buttonNo2_Click(object sender, EventArgs e)
        {
            numberButtonClick("2");
        }

        private void buttonNo3_Click(object sender, EventArgs e)
        {
            numberButtonClick("3");
        }

        private void buttonNo4_Click(object sender, EventArgs e)
        {
            numberButtonClick("4");
        }

        private void buttonNo5_Click(object sender, EventArgs e)
        {
            numberButtonClick("5");
        }

        private void buttonNo6_Click(object sender, EventArgs e)
        {
            numberButtonClick("6");
        }

        private void buttonNo7_Click(object sender, EventArgs e)
        {
            numberButtonClick("7");
        }

        private void buttonNo8_Click(object sender, EventArgs e)
        {
            numberButtonClick("8");
        }

        private void buttonNo9_Click(object sender, EventArgs e)
        {
            numberButtonClick("9");
        }

        private void buttonNo0_Click(object sender, EventArgs e)
        {
            numberButtonClick("0");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (cashierTextBox.Text.Any(char.IsDigit))
            {
                cashierTextBox.Text = cashierTextBox.Text.Substring(0, cashierTextBox.Text.Length - 1);
            }
            else {
                foreach (var f in food)
                {
                    if (cashierTextBox.Text.Contains(f))
                    {
                        cashierTextBox.Text = "";
                    }
                }
            }
        }
        
        private void showOrder()
        {

        }

        private void order()
        {
            if (cashierTextBox.Text != "")
            {
                Quantity q = new Quantity();
                DialogResult dr = q.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    int quantity = q.selectedQuantity;
                    showTotal();
                    showDisplay();
                    displayDataGridView.Size = new Size(displayDataGridView.Width, 640);
                }
                clearText();
            }
            else
            {
                MessageBox.Show("Isi textbox dahulu!");
            }
        }
        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    order();
                    break;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            order();
        }

        //buat searchnya isa ganti
        private void searchVisible(bool s1, bool s2)
        {
            buttonNo1.Visible = s1;
            buttonNo2.Visible = s1;
            buttonNo3.Visible = s1;
            buttonNo4.Visible = s1;
            buttonNo5.Visible = s1;
            buttonNo6.Visible = s1;
            buttonNo7.Visible = s1;
            buttonNo8.Visible = s1;
            buttonNo9.Visible = s1;
            buttonNo0.Visible = s1;
            makanButton.Visible = s1;
            minumButton.Visible = s1;
            snackButton.Visible = s1;
            clearTextButton.Visible = s1;
            deleteButton.Visible = s1;
            menuDataGridView.Visible = s2;
        }

        //buat ganti search
        private void searchBy(string type, bool s1, bool s2)
        {
            clearText();
            searchGroupBox.Text = "Search by " + type;
            searchVisible(s1,s2);
        }

        private void loadMenu()
        {
            try
            {
                query = "SELECT nama_menu AS 'Menu', harga_menu AS 'Harga Menu', quantity AS 'Quantity' FROM menu";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                menuDataGridView.DataSource = dt;
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex.Message);
            }
            con.Close();
        }
        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            loadMenu();
            searchBy("Name",false,true);
        }

        private void searchByIdButton_Click(object sender, EventArgs e)
        {
            searchBy("ID", true, false);
        }

        private void clearDisplayButton_Click(object sender, EventArgs e)
        {
            //lek ad sg buat buat cek lek misale data grid view display kosong, monggo wkwkw, aku lagi mw fokus sg laen (hans)
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin men-delete order?", "Konfirmasi",MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                clearDisplay();
                clearText();
                totalPanel.Visible = false;
                displayDataGridView.Size = new Size(displayDataGridView.Width, 733); //iki height e jok diganti, lek diganti ntik elek
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void menuDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void isiCashierTextbox(string t)
        {
            cashierTextBox.Text = "";
            cashierTextBox.Text = t;
        }
        private void makanButton_Click(object sender, EventArgs e)
        {
            isiCashierTextbox("MAKAN");
        }

        private void minumButton_Click(object sender, EventArgs e)
        {
            isiCashierTextbox("MINUM");
        }

        private void snackButton_Click(object sender, EventArgs e)
        {
            isiCashierTextbox("SNACK");
        }

        private void search() 
        {
            query = "SELECT nama_menu AS 'Menu', harga_menu AS 'Harga Menu', quantity AS 'Quantity' FROM menu WHERE nama_menu LIKE @namaMakan OR id_menu LIKE @idMakan";
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@namaMakan", "%" + cashierTextBox.Text + "%");
                cmd.Parameters.AddWithValue("@idMakan", "%" + cashierTextBox.Text + "%");
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable res = new DataTable();
                res.Load(r);
                menuDataGridView.DataSource = res;
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex.Message);
            }
            con.Close();
        }
        private void cashierTextBox_TextChanged(object sender, EventArgs e)
        {
            if(cashierTextBox.Text == "")
            {
                loadMenu();
            }
            else
            {
                search();
            }
        }

        private void splitPaymentButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
