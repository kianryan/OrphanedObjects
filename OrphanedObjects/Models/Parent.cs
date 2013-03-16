using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrphanedObjects.Models
{
    public class Parent
    {
        public virtual int Id { get; set; }

        private ICollection<Child> _children; 
        public virtual ICollection<Child> Children
        {
            get { return _children ?? (_children = new Collection<Child>()); }
            set { _children = value; }
        } 

        public IEnumerable<Child> RemoveChild(Child child)
        {
            Children.Remove(child);
            return new Child[] { child };
        }
    }
}
