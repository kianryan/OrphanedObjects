using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrphanedObjects.Models;
using Xunit;

namespace OrphanedObjects.Tests
{
    public class OrphanTest : IDisposable
    {
        private readonly Context _context;

        public OrphanTest()
        {
            _context = new Context();

            var parent = new Parent();
            var child = new Child();
            parent.Children.Add(child);

            _context.Parents.Add(parent);
            _context.SaveChanges();
        }

        [Fact]
        public void Remove_Child()
        {
            var parent = _context.Parents.First();
            var child = parent.Children.First();

            parent.Children.Remove(child);

            _context.SaveChanges();
        }

        public void Dispose()
        {
            foreach (var child in _context.Children.ToList())
                _context.Children.Remove(child);
            foreach (var parent in _context.Parents.ToList())
                _context.Parents.Remove(parent);

            _context.SaveChanges();
        }
    }
}
