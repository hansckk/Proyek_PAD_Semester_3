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
    public partial class Cashier : Form
    {
        MySqlConnection con;
        string query;
        public Cashier()
        {
            query = "";
            con = new MySqlConnection("Server=localhost;Database=mcd_pad;User Id=root;Password=;");
            InitializeComponent();
        }

        //ini buat nambah number dek textbox1
        // test
        private void numberButtonClick(string num)
        {
            cashierTextBox.Text += num;
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
            if (!string.IsNullOrEmpty(cashierTextBox.Text))
            {
                cashierTextBox.Text = cashierTextBox.Text.Substring(0, cashierTextBox.Text.Length - 1);
            }
        }
        
        private void order()
        {
            if (cashierTextBox.Text != "")
            {
                Quantity q = new Quantity();
                q.ShowDialog();
                clearText();
                showTotal();
                displayDataGridView.Size = new Size(displayDataGridView.Width, 640);
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
            query = "SELECT nama_menu AS 'Menu', harga_menu AS 'Harga Menu' FROM menu";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            menuDataGridView.DataSource = dt;
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
            clearText();
            totalPanel.Visible = false;
            displayDataGridView.Size = new Size(displayDataGridView.Width, 733); //iki height e jok diganti, lek diganti ntik elek
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void menuDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cashierTextBox.Text = menuDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
