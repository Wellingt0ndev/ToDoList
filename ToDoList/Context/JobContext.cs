using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Context
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
    }
}
