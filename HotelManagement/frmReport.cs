using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmReport : Form
    {
        MyReport Report = new MyReport();
        public frmReport(MyReport _report)
        {
            InitializeComponent();
            Report = _report;
        }

        private void MyReport1_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = Report;
        }
    }
}
