using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MyTaskTrackerLibrary;

namespace DAL.Operators
{
    public class OpTask
    {
        static List<Task> tasks = new List<Task>();
        static Task task = new Task();
        public static List<Task> SelectAllTasks()
        {
            tasks = new List<Task>();

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
                    task = new Task();
                    // get the results of each column
                    task.Id = (int)dr["Id"];
                    task.Title = dr["Title"].ToString().Trim();
                    task.Status = (int)dr["Status"];
                    task.Deleted = (int)dr["Deleted"];
                    task.UserId = (int)dr["UserId"];
                    tasks.Add(task);
                }
            }

            return tasks;
        }

        public static Task SelectTask(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["mttConnectionString"].ConnectionString.ToString();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from tblTask where Id = " + id, sqlConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "TaskTable");
                if(ds.Tables["TaskTable"].Rows.Count == 1)
                {
                    task = new Task();
                    // get the results of each column
                    task.Id = (int)ds.Tables["TaskTable"].Rows[0]["Id"];
                    task.Title = ds.Tables["TaskTable"].Rows[0]["Title"].ToString().Trim();
                    task.Description = ds.Tables["TaskTable"].Rows[0]["Description"].ToString().Trim();
                    task.Status = (int)ds.Tables["TaskTable"].Rows[0]["Status"];
                    task.Deleted = (int)ds.Tables["TaskTable"].Rows[0]["Deleted"];
                    task.UserId = (int)ds.Tables["TaskTable"].Rows[0]["UserId"];
                }
            }
            return task;
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
