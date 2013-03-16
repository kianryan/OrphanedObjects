namespace OrphanedObjects.Models
{
    public class Child
    {
        public virtual int Id { get; set; }

        public virtual int ParentId { get; set; }
        public virtual Parent Parent { get; set; }
    }
}