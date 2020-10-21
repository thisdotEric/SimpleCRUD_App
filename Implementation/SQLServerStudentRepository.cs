using StudentDataAccess.Interface; 
using StudentDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StudentDataAccess.Implementation
{
    public class SQLServerStudentRepository : IStudentRepository, IHaveConnectionString
    {
        private readonly string dbName = "SQLServerStudentDatabase";

        public async Task AddNewStudent(IStudent student)
        {
            using (var conection = new SqlConnection(GetConnectionString(dbName)))
            {
                using (var command = new SqlCommand("dbo.spAddNewStudent", conection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@studentId", student.StudentId);
                    command.Parameters.AddWithValue("@fname", student.FirstName);
                    command.Parameters.AddWithValue("@mname", student.MiddleName);
                    command.Parameters.AddWithValue("@lname", student.LastName);
                    command.Parameters.AddWithValue("@course", student.Course);
                    command.Parameters.AddWithValue("@yearLevel", student.YearLevel);

                    await conection.OpenAsync().ConfigureAwait(false);
                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                }
            }
        }

        public async Task DeleteStudent(string studentId)
        {
            using (var connection = new SqlConnection(GetConnectionString(dbName)))
            {
                using (var command = new SqlCommand("dbo.spDeleteStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync().ConfigureAwait(false);
                    command.Parameters.AddWithValue("@studentId", studentId);

                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);
                }
            }
        }

        public async Task<IEnumerable<IStudent>> GetAllStudents()
        {
            using (var conection = new SqlConnection(GetConnectionString(dbName)))
            {
                using (var command = new SqlCommand("dbo.spGetAllStudents", conection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await conection.OpenAsync().ConfigureAwait(false);
                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);

                    List<Student> students = null;

                    using (var dataReader = await command.ExecuteReaderAsync())
                    {
                        if (dataReader.HasRows)
                        {
                            students = new List<Student>();

                            while (await dataReader.ReadAsync())
                            {
                                var student = new Student()
                                {
                                    StudentId = dataReader["StudentId"].ToString(),
                                    FirstName = dataReader["FirstName"].ToString(),
                                    MiddleName = dataReader["MiddleName"].ToString(),
                                    LastName = dataReader["MiddleName"].ToString(),
                                    Course = dataReader["Course"].ToString(),
                                    YearLevel = Convert.ToInt32(dataReader["YearLevel"].ToString())
                                };

                                students.Add(student);

                            }
                        }
                        return students;
                    }
                }
            }
        }

        public async Task<IStudent> GetIndividualStudent(string studentId)
        {
            using (var conection = new SqlConnection(GetConnectionString(dbName)))
            {
                using (var command = new SqlCommand("dbo.spGetIndividualStudent", conection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@studentId", studentId);

                    await conection.OpenAsync().ConfigureAwait(false);
                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);

                    using (var dataReader = await command.ExecuteReaderAsync().ConfigureAwait(false))
                    {
                        if (dataReader.HasRows)
                        {
                            while (await dataReader.ReadAsync())
                            {
                                return new Student()
                                {
                                    StudentId = dataReader["StudentId"].ToString(),
                                    FirstName = dataReader["FirstName"].ToString(),
                                    MiddleName = dataReader["MiddleName"].ToString(),
                                    LastName = dataReader["MiddleName"].ToString(),
                                    Course = dataReader["Course"].ToString(),
                                    YearLevel = Convert.ToInt32(dataReader["Year Level"].ToString())
                                };
                            }
                        }
                        return null;
                    }
                }
            }
        }

        public string GetConnectionString(string dbName)
        {
            return ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }
    }
}
