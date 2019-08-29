using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MyTaskTrackerLibrary;

namespace DAL.Operators
{
    public class OpTask
    {
        public static List<Task> SelectAll()
        {
            List<Task> tasks = new List<Task>();

            //Retrieving data using SqlDataReader
            //string connectionString = ConfigurationManager.ConnectionStrings["mttConnectionString"].ConnectionString.ToString();
            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand("Select * from tblTask", sqlConnection);
            //    using (SqlDataReader sdr = sqlCommand.ExecuteReader())
            //    {
            //        while (sdr.Read())
            //        {
            //            Task t = new Task();
            //            // get the results of each column
            //            t.Id = (int)sdr["Id"];
            //            t.Title = sdr["Title"].ToString().Trim();
            //            t.Status = (int)sdr["Status"];
            //            t.Deleted = (int)sdr["Deleted"];
            //            t.UserId = (int)sdr["UserId"];
            //            tasks.Add(t);
            //        } 
            //    }
            //}

            //Retrieving data using SqlDataAdapter
            string connectionString = ConfigurationManager.ConnectionStrings["mttConnectionString"].ConnectionString.ToString();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from tblTask", sqlConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tasks");
                foreach (DataRow dr in ds.Tables["Tasks"].Rows)
                {
                    Task t = new Task();
                    // get the results of each column
                    t.Id = (int)dr["Id"];
                    t.Title = dr["Title"].ToString().Trim();
                    t.Status = (int)dr["Status"];
                    t.Deleted = (int)dr["Deleted"];
                    t.UserId = (int)dr["UserId"];
                    tasks.Add(t);
                }
            }

            return tasks;
        }

        public void Select()
        {

        }

        public void Insert()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
