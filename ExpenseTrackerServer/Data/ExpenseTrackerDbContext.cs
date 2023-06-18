using ExpenseTrackerServer.Models;
using Microsoft.EntityFrameworkCore;
namespace ExpenseTrackerServer.Data
{
    public class ExpenseTrackerDbContext : DbContext
    {

        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options) { }

        public DbSet<Expenses> Expenses { get; set; }
    }
}
