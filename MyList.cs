namespace Generics
{
    public class MyList<T>
    {
        List<T> list;

        public MyList()
        {
            list = new List<T>();
        }
        void Add(T element)
        {
            list.Add(element);
        }
        T Remove(int index)
        {
            T element = list[index];
            list.RemoveAt(index);
            return element;
        }
        bool Contains(T element)
        {
            return list.Contains(element);
        }
        void Clear()
        {
            list.Clear();
        }
        void InsertAt(T element, int index)
        {
            list.Insert(index, element);
        }
        void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }
        T Find(int index)
        {
            return (T)list[index];
        }
    }
}
