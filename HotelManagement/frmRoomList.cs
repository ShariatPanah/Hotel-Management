using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.DAL;
using Hotel_Management.BLL;

namespace HotelManagement
{
    public partial class frmRoomList : Form
    {
        public frmRoomList()
        {
            InitializeComponent();
        }

        private void frmRoomList_Load(object sender, EventArgs e)
        {
            cmbOrder.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(HotelManagementDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            if (cmbOrder.SelectedIndex == 0)
            {
                try
                {
                    Connection.Open();
                    Command.Connection = Connection;
                    Command.CommandText = "Select * From Room";

                    DataTable Table = new DataTable();
                    SqlDataReader Reader= Command.ExecuteReader();
                    Table.Load(Reader);

                    dgvRoomList.DataSource = null;
                    dgvRoomList.DataSource = Table;
                }
                finally
                {
                    if (Connection.State==ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                }
            }
            else if (cmbOrder.SelectedIndex == 1)
            {
                try
                {
                    Connection.Open();
                    Command.Connection = Connection;
                    Command.CommandText = "Select * From Room where RoomStatus='آماده'";

                    DataTable Table = new DataTable();
                    SqlDataReader Reader = Command.ExecuteReader();
                    Table.Load(Reader);

                    dgvRoomList.DataSource = null;
                    dgvRoomList.DataSource = Table;
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                }
            }
            else
            {
                try
                {
                    Connection.Open();
                    Command.Connection = Connection;
                    Command.CommandText = "Select * From Room where RoomStatus='پُر است'";

                    DataTable Table = new DataTable();
                    SqlDataReader Reader = Command.ExecuteReader();
                    Table.Load(Reader);

                    dgvRoomList.DataSource = null;
                    dgvRoomList.DataSource = Table;
                }
                finally
                {
                    if (Connection.State == ConnectionState.Open)
                    {
                        Connection.Close();
                    }
                }
            }
        }
    }
}
