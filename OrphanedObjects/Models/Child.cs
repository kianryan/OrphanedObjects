using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrphanedObjects.Models
{
    public class Child
    {
        [Key, Column(Order = 1)]
        public virtual int Id { get; set; }

        [Key, Column(Order = 2)]
        public virtual int ParentId { get; set; }
        public virtual Parent Parent { get; set; }
    }
}