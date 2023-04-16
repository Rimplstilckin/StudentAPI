using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudents()
        {
            List<Student> results = new List<Student> ();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Studets";

                sqlConnection.Open ();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                Student s = new Student();

                while (sqlDataReader.Read())
                {
                    s.Id = sqlDataReader.GetInt32(0);
                    s.StudentName = sqlDataReader.GetString(1);
                    s.IndexNumber = sqlDataReader.GetString(2);
                    s.PointsESPB = sqlDataReader.GetInt32(3);
                    s.StudyYear = sqlDataReader.GetInt32(4);
                    s.AverageMark = sqlDataReader.GetDecimal(5);
                    s.IsBudget = sqlDataReader.GetBoolean(6);

                    results.Add(s);
                }
            }

            return results;
        }
    }
}
