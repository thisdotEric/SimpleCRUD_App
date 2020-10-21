namespace StudentDataAccess.Interface
{
    public interface IHaveConnectionString
    {
        string GetConnectionString(string dbName);
    }
}
