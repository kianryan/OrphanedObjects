using System.Data.Entity;
using System.Linq;

namespace OrphanedObjects.Models
{
    public class Context : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }

        public override int SaveChanges()
        {
            var toRemove = Children.Local.Where(x => x.Parent == null).ToList();
            foreach (var child in toRemove)
                Children.Remove(child);

            return base.SaveChanges();
        }
    }
}