using System.Data.Entity;

namespace OrphanedObjects.Models
{
    public class Context : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
    }
}