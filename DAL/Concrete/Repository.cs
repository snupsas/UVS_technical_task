using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using DAL.Abstract;

namespace DAL
{
    public class Repository : IRepository
    {
        private OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConfigurationManager.ConnectionStrings["ThreadDBConnectionString"].ConnectionString);
        }

        public void Create(int threadID, string generatedData, DateTime generationDate)
        {
            var connection = GetConnection();
            string queryString = "INSERT INTO ThreadData (ThreadID, [Time], Data) VALUES (@ThreadID, @Time, @Data)";

            using (connection)
            {
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.Parameters.Add("@ThreadID", OleDbType.Integer).Value = threadID;
                    command.Parameters.Add("@Time", OleDbType.Date).Value = generationDate;
                    command.Parameters.Add("@Data", OleDbType.WChar).Value = generatedData;
                   
                    try
                    {
                        if (connection.State != System.Data.ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }         
        }
    }
}
