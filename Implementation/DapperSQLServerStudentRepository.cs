using Dapper;
using StudentDataAccess.Interface;
using StudentDataAccess.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDataAccess.Implementation
{
    public class DapperSQLServerStudentRepository : IStudentRepository, IHaveConnectionString
    {
        private readonly string dbName = "SQLServerStudentDatabase";

        public async Task AddNewStudent(IStudent student)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString(dbName)))
            {
                var sqlParameter = new DynamicParameters();
                sqlParameter.Add("@studentId", student.StudentId, DbType.String, ParameterDirection.Input);
                sqlParameter.Add("@fname", student.FirstName, DbType.String, ParameterDirection.Input);
                sqlParameter.Add("@mname", student.MiddleName, DbType.String, ParameterDirection.Input);
                sqlParameter.Add("@lname", student.LastName, DbType.String, ParameterDirection.Input);
                sqlParameter.Add("@course", student.Course, DbType.String, ParameterDirection.Input);
                sqlParameter.Add("@yearLevel", student.YearLevel, DbType.Int32, ParameterDirection.Input);

                await connection.ExecuteAsync("dbo.spAddNewStudent", sqlParameter, null, null, CommandType.StoredProcedure);
            }
        }

        public async Task DeleteStudent(string studentId)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString(dbName)))
            {
                await connection.ExecuteAsync("dbo.spDeleteStudent", new
                {
                    studentId = studentId
                },
                null, null, CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<IStudent>> GetAllStudents()
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString(dbName)))
            {
                var students = await connection.QueryAsync<Student>("dbo.spGetAllStudents", CommandType.StoredProcedure);

                return students;
            }
        }

        public async Task<IStudent> GetIndividualStudent(string studentId)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString(dbName)))
            {
                var students = await connection.QueryAsync<Student>("dbo.spGetIndividualStudent", new
                {
                    studentId = studentId
                }, null, null, CommandType.StoredProcedure);

                return students.FirstOrDefault();
            }
        }

        public string GetConnectionString(string dbName)
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }
    }
}
