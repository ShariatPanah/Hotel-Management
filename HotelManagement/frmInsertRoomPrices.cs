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

namespace HotelManagement
{
    public partial class frmInsertRoomPrices : Form
    {
        public frmInsertRoomPrices()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = HotelManagementDAL.GetPrices();
            dgvRoomPrice.DataSource = null;
            dgvRoomPrice.DataSource = Table;
        }

        private void frmInsertRoomPrices_Load(object sender, EventArgs e)
        {
            FillGrid();
            cmbCapacity.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HotelManagementDAL.InsertPrices(int.Parse(txtPrice.Text), cmbCapacity.SelectedIndex + 1);
            cmbCapacity.SelectedIndex = 0;
            txtPrice.Text = "";

            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvRoomPrice.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];

            HotelManagementDAL.DeletePrice(id);
            FillGrid();
        }

        private void dgvRoomPrice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoomPrice.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
