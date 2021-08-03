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
    public partial class frmAddNewPassenger : Form
    {
        frmDefray Defray;
        public frmAddNewPassenger()
        {
            InitializeComponent();
            cmbMonth.SelectedIndex = 0;
        }

        public void FillGrid()
        {
            DataTable Table = HotelManagementDAL.GetPassengers();
            dgvAddPassenger.DataSource = null;
            dgvAddPassenger.DataSource = Table;
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex + 1 <= 6)
            {
                cmbDay.Enabled = true;
                cmbDay.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    if (i < 10)
                    {
                        cmbDay.Items.Add("0"+ i);
                    }
                    else
                    {
                        cmbDay.Items.Add(i);
                    }
                }
                cmbDay.SelectedIndex = 0;
            }
            else if (cmbMonth.SelectedIndex + 1 < 12)
            {
                cmbDay.Enabled = true;
                cmbDay.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    cmbDay.Items.Add(i);
                    cmbDay.SelectedIndex = 0;
                }
            }
            else
            {
                cmbDay.Enabled = true;
                cmbDay.Items.Clear();
                for (int i = 1; i <= 29; i++)
                {
                    cmbDay.Items.Add(i);
                    cmbDay.SelectedIndex = 0;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Passenger oPassenger = new Passenger();
            oPassenger.Name = txtName.Text.Trim();
            oPassenger.Family = txtFamily.Text.Trim();
            oPassenger.NationCode = long.Parse(txtNationCode.Text.Trim());
            oPassenger.FatherName = txtFatherName.Text.Trim();
            oPassenger.BirthDate = mtbYear.Text.Trim() + "-" + (cmbMonth.SelectedItem) + "-" + (cmbDay.SelectedItem);
            oPassenger.RoomNo = int.Parse(txtRoomNo.Text.Trim());
            oPassenger.StayingNights = int.Parse(txtStayingNights.Text.Trim());
            oPassenger.SubmitTime = Converting.PersianDate(DateTime.Now.ToString(), true, true);

            HotelManagementDAL.InsertPassenger(oPassenger);

            txtName.Text = "";
            txtFamily.Text = "";
            txtNationCode.Text = "";
            txtFatherName.Text = "";
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            mtbYear.Text = "";
            txtRoomNo.Text = "";
            txtStayingNights.Text = "";

            FillGrid();
            txtName.Focus();
        }

        private void frmAddNewPassenger_Load(object sender, EventArgs e)
        {
            this.FillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAddPassenger_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddPassenger.SelectedRows.Count > 0)
            {
                btnDefray.Enabled = true;
            }
            else
            {
                btnDefray.Enabled = false;
            }
        }

        private void btnDefray_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvAddPassenger.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];

            Defray = new frmDefray(id);
            Defray.ShowDialog();

            FillGrid();
        }
    }
}
