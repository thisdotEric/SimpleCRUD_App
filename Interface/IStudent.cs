namespace StudentDataAccess.Interface
{
    public interface IStudent : IPerson
    {
        string Course { get; set; }

        string StudentId { get; set; }

        int YearLevel { get; set; }
    }
}
