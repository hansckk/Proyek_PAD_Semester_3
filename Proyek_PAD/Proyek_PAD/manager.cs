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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        //tombol bermasalah, lek ad sg isa benakno tolong benakno pliss wkwkwk
        private void button1_Click(object sender, EventArgs e)
        {
            karyawan_form kf = new karyawan_form();
            this.Hide();
            DialogResult res = kf.ShowDialog();
            if(res == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makanan_form mf = new makanan_form();
            this.Hide();
            DialogResult res = mf.ShowDialog();
            if(res == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            laporan l = new laporan();
            this.Hide();
            DialogResult res = l.ShowDialog();
            if(res == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
