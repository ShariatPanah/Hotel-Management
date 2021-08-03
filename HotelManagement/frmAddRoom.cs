using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.DAL;
using Hotel_Management.BLL;
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            DataTable Table = HotelManagementDAL.GetRooms();
            dgvAddRoom.DataSource = null;
            dgvAddRoom.DataSource = Table;
        }

        public int CheckPriceForm()
        {
            SqlConnection Connection = new SqlConnection(HotelManagementDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select COUNT(Capacity)As MyCount From RoomsPrices";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                int Count = Convert.ToInt32(Table.Rows[0]["MyCount"]);

                return Count;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            int MyCount = CheckPriceForm();
            if (MyCount > 0)
            {
                FillGrid();
                groupBox1.Enabled = true;
                lblCapacity.Enabled = true;
                lblNo.Enabled = true;
                txtRoomCapacity.Enabled = true;
                txtRoomNo.Enabled = true;
                btnAdd.Enabled = true;
                dgvAddRoom.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = true;
                lblError.Enabled = true;
                lblError.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvAddRoom.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];
            HotelManagementDAL.DeleteRoom(id);

            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvAddRoom.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];

            frmEditRoom EditRoom = new frmEditRoom(id);
            EditRoom.ShowDialog();

            FillGrid();
        }
        private void dgvAddRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddRoom.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room oRoom = new Room();
            oRoom.RoomNo = Convert.ToInt32(txtRoomNo.Text);
            oRoom.RoomCapacity = Convert.ToInt32(txtRoomCapacity.Text);

            HotelManagementDAL.InsertRoom(oRoom);

            txtRoomNo.Text = "";
            txtRoomCapacity.Text = "";
            txtRoomNo.Focus();

            FillGrid();
        }
    }
}
