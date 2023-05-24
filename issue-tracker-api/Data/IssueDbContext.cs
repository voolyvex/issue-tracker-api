using Microsoft.EntityFrameworkCore;
using issue_tracker_api.Models;

namespace issue_tracker_api.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }
    }
}
