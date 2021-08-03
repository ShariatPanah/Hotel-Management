using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.BLL;
using Hotel_Management.DAL;
using Converting_Date;

namespace HotelManagement
{
    public partial class frmDefray : Form
    {
        int _id;
        public frmDefray(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDefray_Load(object sender, EventArgs e)
        {
            Passenger oPassenger = new Passenger();
            oPassenger = HotelManagementDAL.GetOnePassenger(_id);
            txtName.Text = oPassenger.Name;
            txtFamily.Text = oPassenger.Family;
            txtNCode.Text = Convert.ToString(oPassenger.NationCode);
            txtRoomNo.Text = oPassenger.RoomNo.ToString();
            txtSubmitTime.Text = oPassenger.SubmitTime;
            txtDefray.Text = oPassenger.DefrayTime;
            txtAmount.Text = oPassenger.Amount.ToString();

        }

        private void btnSubmitDefray_Click(object sender, EventArgs e)
        {
            HotelManagementDAL.DeletePassenger(_id, txtDefray.Text.ToString());

            MessageBox.Show("اتاق مربوط به این مهمان تخلیه شد");

            this.Close();
        }
    }
}
