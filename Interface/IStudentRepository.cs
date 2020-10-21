using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentDataAccess.Interface
{
    public interface IStudentRepository
    {
        Task<IEnumerable<IStudent>> GetAllStudents();

        Task<IStudent> GetIndividualStudent(string studentId);

        Task AddNewStudent(IStudent student);

        Task DeleteStudent(string studentId);
    }
}
