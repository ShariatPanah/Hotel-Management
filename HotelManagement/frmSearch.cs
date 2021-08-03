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
using Converting_Date;

namespace HotelManagement
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(HotelManagementDAL.ConnectionString);
        SqlCommand Command = new SqlCommand();

        string StartDate = string.Empty;
        string EndDate = string.Empty;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDatatSet = new DataSet();

            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Passenger Where Name Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", txtName.Text + "%");

            DataAdapter.Fill(oDatatSet, "TempTable");

            dgvSearch.DataSource = oDatatSet;
            dgvSearch.DataMember = "TempTable";
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime oDate = DateTime.Now;
            mtbStartDate.Text = Converting.PersianDate(oDate.ToString(), false, true);
            mtbEndDate.Text = Converting.PersianDate(oDate.ToString(), false, true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StartDate = mtbStartDate.Text + " 00:00:00";
            EndDate = mtbEndDate.Text + " 23:59:59";

            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();

            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Passenger Where SubmitTime >= @StartDate and SubmitTime <= @EndDate";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", StartDate);
            DataAdapter.SelectCommand.Parameters.AddWithValue("EndDate", EndDate);

            DataAdapter.Fill(oDataSet, "TempTable");

            dgvSearch.DataSource = oDataSet;
            dgvSearch.DataMember = "TempTable";
        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();

            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Passenger Where Family Like @Temp";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@Temp", txtFamily.Text + "%");

            DataAdapter.Fill(oDataSet, "TempTable");

            dgvSearch.DataSource = oDataSet;
            dgvSearch.DataMember = "TempTable";
        }

        private void txtNCode_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();

            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Passenger Where NationCode Like @Temp";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@Temp", txtNCode.Text + "%");

            DataAdapter.Fill(oDataSet, "TempTable");
            dgvSearch.DataSource = oDataSet;
            dgvSearch.DataMember = "TempTable";
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();

            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select * From Passenger Where RoomNo Like @Temp";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@Temp", txtRoomNo.Text + "%");

            DataAdapter.Fill(oDataSet, "TempTable");

            dgvSearch.DataSource = oDataSet;
            dgvSearch.DataMember = "TempTable";
        }
    }
}
