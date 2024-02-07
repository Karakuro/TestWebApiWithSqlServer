using Microsoft.EntityFrameworkCore;

namespace TestWebApiWithSqlServer.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) 
            : base(options) { }

        public DbSet<ActivityTask> ActivityTasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
