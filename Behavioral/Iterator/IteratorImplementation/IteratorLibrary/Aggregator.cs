using System.Collections;

namespace IteratorLibrary
{
    public class Aggregator<T> : IAggregator<T>
    {
        private readonly ArrayList _items = new ArrayList();

        public T this[int index] { get => (T)_items[index]; set => _items.Insert(index, value); }

        public int Count()
        {
            return _items.Count;
        }

        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }
    }
}