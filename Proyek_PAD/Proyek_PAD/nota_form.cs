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
    public partial class nota_form : Form
    {
        public nota_form(int id,string u)
        {
            InitializeComponent();
            // code crystal report e ojok diatas InitializeComponent(); lek gak null error ngkok
            CrystalReport1 report = new CrystalReport1();
            report.SetDatabaseLogon("<user_id>", "<password>", "localhost", "mcd_pad");
            report.SetParameterValue("transid", id);
            report.SetParameterValue("crewnama", u);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void nota_form_Load(object sender, EventArgs e)
        {

        }
    }
}
