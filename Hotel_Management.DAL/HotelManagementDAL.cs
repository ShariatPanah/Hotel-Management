using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management.BLL;
using Converting_Date;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management.DAL
{
    public class HotelManagementDAL
    {
        public static string ConnectionString = 
            "Data Source=(local);Initial Catalog=Hotel Management;Integrated Security=True;";

        public static int Login(string User, string Pass)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select Count(Username) From [User] Where Username='{0}' And Password='{1}'", User, Pass);

                int Counter = (int)Command.ExecuteScalar();
                return Counter;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewUser(User oUser)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();

            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Insert into [User] Select @Username, @Password";

                Command.Parameters.AddWithValue("@Username", oUser.Username);
                Command.Parameters.AddWithValue("@Password", oUser.Password);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From [User]");

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteUser(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From [User] Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertRoom(Room oRoom)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertRoom";

                Command.Parameters.AddWithValue("@RoomNo", oRoom.RoomNo);
                Command.Parameters.AddWithValue("@RoomCapacity", oRoom.RoomCapacity);

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

        public static void InsertPassenger(Passenger oPassenger)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertPassenger";

                Command.Parameters.AddWithValue("@Name", oPassenger.Name);
                Command.Parameters.AddWithValue("Family", oPassenger.Family);
                Command.Parameters.AddWithValue("@NCode", oPassenger.NationCode);
                Command.Parameters.AddWithValue("@FatherName", oPassenger.FatherName);
                Command.Parameters.AddWithValue("@BirthDate", oPassenger.BirthDate);
                Command.Parameters.AddWithValue("@RoomNo", oPassenger.RoomNo);
                Command.Parameters.AddWithValue("StayingNights", oPassenger.StayingNights);
                Command.Parameters.AddWithValue("SubmitTime", oPassenger.SubmitTime);

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

        public static DataTable GetPassengers()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Passenger Where DefrayTime='تخلیه نشده'";
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        public static Passenger GetOnePassenger(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From Passenger Where ID={0}", id);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                Passenger oPassenger = new Passenger();
                oPassenger.Name = Convert.ToString(Table.Rows[0]["Name"]);
                oPassenger.Family = Convert.ToString(Table.Rows[0]["Family"]);
                oPassenger.NationCode = Convert.ToInt64(Table.Rows[0]["NationCode"]);
                oPassenger.FatherName = Convert.ToString(Table.Rows[0]["FatherName"]);
                oPassenger.BirthDate = Convert.ToString(Table.Rows[0]["BirthDate"]);
                oPassenger.RoomNo = Convert.ToInt32(Table.Rows[0]["RoomNo"]);
                oPassenger.StayingNights = Convert.ToInt32(Table.Rows[0]["StayingNights"]);
                oPassenger.Amount = Convert.ToInt64(Table.Rows[0]["Amount"]);
                oPassenger.SubmitTime = Convert.ToString(Table.Rows[0]["SubmitTime"]);
                oPassenger.DefrayTime = Converting.PersianDate(DateTime.Now.ToString(), true, true);

                return oPassenger;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetPrices()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From RoomsPrices";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetRooms()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Room";
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Room GetOneRoom(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From Room Where ID={0}", id);
                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                Room oRoom = new Room();
                oRoom.RoomNo = Convert.ToInt32(Table.Rows[0]["RoomNo"]);
                oRoom.RoomCapacity = Convert.ToInt32(Table.Rows[0]["RoomCapacity"]);
                oRoom.RoomPrice = Convert.ToInt64(Table.Rows[0]["PriceOneNight"]);
                oRoom.RoomStatus = Convert.ToString(Table.Rows[0]["RoomStatus"]);

                return oRoom;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertPrices(int Price, int Capacity)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Insert into RoomsPrices select {0}, {1}", Capacity, Price);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State== ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeletePrice(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From RoomsPrices Where ID={0}", id);

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

        public static void DeleteRoom(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From Room Where ID={0}", id);

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

        public static void DeletePassenger(int id, string DefrayTime)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"DeletePassenger";

                Command.Parameters.AddWithValue("@ID", id);
                Command.Parameters.AddWithValue("@DefrayTime", DefrayTime);

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
