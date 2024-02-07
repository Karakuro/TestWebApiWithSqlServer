namespace TestWebApiWithSqlServer.Data
{
    public class ActivityTask
    {
        public int ActivityTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
