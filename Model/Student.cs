using StudentDataAccess.Interface;

namespace StudentDataAccess.Model
{
    public class Student : IStudent
    {
        public string StudentId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Course { get; set; }

        public int YearLevel { get; set; }

    }
}
