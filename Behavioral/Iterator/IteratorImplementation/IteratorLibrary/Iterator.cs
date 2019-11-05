
namespace IteratorLibrary
{
    public class Iterator<T> : IIterator<T>
    {
        private readonly IAggregator<T> _aggregator;

        private int _currentIndex;

        public Iterator(IAggregator<T> aggregator)
        {
            _aggregator = aggregator;
            _currentIndex = 0;
        }

        public void Add(T item)
        {
            int lastIndex = _aggregator.Count();
            _aggregator[lastIndex] = item;
        }

        public T CurrentItem()
        {
            return _aggregator[_currentIndex];
        }

        public T First()
        {
            return _aggregator[0];
        }

        public T LastItem()
        {
            int lastIndex = _aggregator.Count() - 1;
            return _aggregator[lastIndex];
        }

        public T NextItem()
        {
            int lastIndex = _aggregator.Count() - 1;
            if (_currentIndex < lastIndex)
            {
                _currentIndex++;
            }
            else
            {
                _currentIndex = 0;
            }

            return _aggregator[_currentIndex];
        }

        public T PreviousItem()
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
            }
            else
            {
                int lastIndex = _aggregator.Count() - 1;
                _currentIndex = lastIndex;
            }

            return _aggregator[_currentIndex];
        }
    }
}