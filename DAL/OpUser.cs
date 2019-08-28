using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MyTaskTrackerLibrary;

namespace DAL.Operators
{
    public class OpUser
    {
        public static List<Task> Select()
        {
            List<Task> tasks = new List<Task>();

            string connectionString = ConfigurationManager.ConnectionStrings["mttConnectionString"].ConnectionString.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from tblTask", sqlConnection);
                using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Task t = new Task();
                        // get the results of each column
                        t.Id = (int)sdr["Id"];
                        t.Title = sdr["Title"].ToString().Trim();
                        t.Status = (int)sdr["Status"];
                        t.Deleted = (int)sdr["Deleted"];
                        t.UserId = (int)sdr["UserId"];
                        tasks.Add(t);
                    } 
                }
            }
            return tasks;
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
