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
    public partial class details_form : Form
    {
        int transId;
        public details_form(int transId)
        {
            this.transId = transId;
            InitializeComponent();
        }
    }
}
