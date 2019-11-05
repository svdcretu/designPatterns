// ------------------------------------------------------------------------------
namespace IteratorLibrary
{
    public interface IIterator<T>
    {
        void Add(T item);

        T CurrentItem();

        T First();

        T NextItem();

        T PreviousItem();

        T LastItem();
    }
}