using System.Data.Entity;
using DataGridViewEx.Entities;

namespace DataGridViewEx
{
    public class AppDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}