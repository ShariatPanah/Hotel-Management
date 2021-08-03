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
using System.Data.SqlClient;

namespace HotelManagement
{
    public partial class frmEditRoom : Form
    {
        int _id;
        public frmEditRoom(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmEditRoom_Load(object sender, EventArgs e)
        {
            Room oRoom = new Room();
            oRoom = HotelManagementDAL.GetOneRoom(_id);

            txtRoomNo.Text = Convert.ToString(oRoom.RoomNo);
            txtRoomCapacity.Text = Convert.ToString(oRoom.RoomCapacity);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(HotelManagementDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"UpdateRoom";

                Command.Parameters.AddWithValue("@ID", _id);
                Command.Parameters.AddWithValue("@RoomNo", txtRoomNo.Text.ToString());
                Command.Parameters.AddWithValue("@RoomCapacity", txtRoomCapacity.Text.ToString());

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

    }
}
