using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converting_Date;
using System.Globalization;

namespace HotelManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNewPassenger_Click(object sender, EventArgs e)
        {
            frmAddNewPassenger AddNewPassenger = new frmAddNewPassenger();
            AddNewPassenger.Show();
            frmRoomList RoomList = new frmRoomList();
            RoomList.Show();
        }

        private void btnPriceSubmit_Click(object sender, EventArgs e)
        {
            frmInsertRoomPrices InsertPrices = new frmInsertRoomPrices();
            InsertPrices.ShowDialog();
        }
        private void btnAddRooms_Click(object sender, EventArgs e)
        {
            frmAddRoom AddRoom = new frmAddRoom();
            AddRoom.ShowDialog();
        }

        private void btnRoomList_Click(object sender, EventArgs e)
        {
            frmRoomList RoomList = new frmRoomList();
            RoomList.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReportOptions ReportOptions = new frmReportOptions();
            ReportOptions.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch Search = new frmSearch();
            Search.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar P = new PersianCalendar();
            this.label2.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);

            this.label3.Text = Converting.ConvertDay() + " " + P.GetDayOfMonth(DateTime.Now) + " " + Converting.ConvertMonth() + " " + P.GetYear(DateTime.Now);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }
    }
}
