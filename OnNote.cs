using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Note
{
    class OnNote
    {
        public string title { get; set; }
        public string message { get; set; }
        public string timeDate { get; set; }
        public string lmod { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool insert(OnNote log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            string sql = "INSERT INTO OneTab(Title, Message, Time_date, Last_Modified) values(@Title, @Message, @Time_date, @Last_Modified)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", log.title);
            cmd.Parameters.AddWithValue("@Message", log.message);
            cmd.Parameters.AddWithValue("@Time_date", log.timeDate);
            cmd.Parameters.AddWithValue("@Last_Modified", log.lmod);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            conn.Close();
            return success;
        }

        public bool Update(OnNote log)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            //try
            //{
            SqlCommand cmd = new SqlCommand("UPDATE OneTab SET Message=@Message, Last_Modified=@Last_Modified where Title=@Title", conn);
            cmd.Parameters.AddWithValue("@Title", log.title);
            cmd.Parameters.AddWithValue("@Message", log.message);
            cmd.Parameters.AddWithValue("@Last_Modified", log.lmod);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }

            // }

            //catch (Exception ex)
            //{

            // }

            //finally
            //{
            conn.Close();

            //}
            return isSuccess;

        }


    }
}
