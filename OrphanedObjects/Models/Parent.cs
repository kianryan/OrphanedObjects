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

        public bool RemoveChild(Child child, out IEnumerable<Child> toRemove)
        {
            var removeTracker = new List<Child>();

            Children.Remove(child);
            removeTracker.Add(child);

            // Side-effects occuring as of business logic.

            toRemove = removeTracker;
            return true;
        }
    }
}
