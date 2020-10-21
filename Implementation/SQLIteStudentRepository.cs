using Dapper;
using StudentDataAccess.Interface;
using StudentDataAccess.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDataAccess.Implementation
{
    public class SQLIteStudentRepository : IStudentRepository, IHaveConnectionString
    {
        private readonly string dbName = "SQLiteStudentDatabase";

        public async Task AddNewStudent(IStudent student)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString(dbName)))
            {
                await connection.ExecuteAsync("INSERT INTO StudentRecord(StudentId, FirstName, MiddleName, LastName, Course, YearLevel) " +
                    "VALUES(@StudentId, @FirstName, @MiddleName, @LastName, @Course, @YearLevel)", student);
            }
        }

        public async Task DeleteStudent(string studentId)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString(dbName)))
            {
                await connection.ExecuteAsync("DELETE FROM StudentRecord WHERE StudentId = @StudentId", new { StudentId = studentId });
            }
        }

        public async Task<IEnumerable<IStudent>> GetAllStudents()
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString(dbName)))
            {
                var students = await connection.QueryAsync<Student>("SELECT * FROM StudentRecord");

                return students;
            }
        }

        public async Task<IStudent> GetIndividualStudent(string studentId)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString(dbName)))
            {
                var students = await connection.QueryAsync<Student>("SELECT * FROM StudentRecord WHERE StudentId = @StudentId", new { StudentId = studentId });
                return students.FirstOrDefault();
            }
        }

        public string GetConnectionString(string dbName = "SQLiteStudentDatabase")
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }

    }
}
