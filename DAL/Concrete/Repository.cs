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
            string queryString = "INSERT INTO ThreadData (ThreadID, Data, CreationDate) VALUES (@ThreadID, @Data, @CreationDate)";

            using (connection)
            {
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.Parameters.Add("@ThreadID", OleDbType.Integer).Value = threadID;
                    command.Parameters.Add("@Data", OleDbType.WChar).Value = generatedData;
                    command.Parameters.Add("@CreationDate", OleDbType.Date).Value = generationDate;

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
