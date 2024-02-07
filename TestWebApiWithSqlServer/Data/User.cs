namespace TestWebApiWithSqlServer.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<ActivityTask> Tasks { get; set; }
    }
}
