using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_PAD
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        //ini buat nambah number dek textbox1
        // test
        private void numberButtonClick(string num)
        {
            idTextBox.Text += num;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonNo1_Click(object sender, EventArgs e)
        {
            numberButtonClick("1");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
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
            if (!string.IsNullOrEmpty(idTextBox.Text))
            {
                idTextBox.Text = idTextBox.Text.Substring(0, idTextBox.Text.Length - 1);
            }
        }
        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    MessageBox.Show("success"); //Mek gae debugging, lek klian mau ganti yo gpp
                    break;
            }
        }
    }
}
