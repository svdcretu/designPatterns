
namespace IteratorLibrary
{
    public interface IAggregator<T>
    {
        IIterator<T> CreateIterator();
        int Count();

        T this[int index] { get; set; }
    }
}