using System;

namespace MyOwnCollection
{
    /// <summary>
    /// Ячейка списка.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        /// <summary>
        /// Данные в ячейке списка.
        /// </summary>
        private T data = default(T);
        /// <summary>
        /// Свойство доступа к элементу списка.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// Указатель на следующий элемент списка.
        /// </summary>
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()=> Data.ToString();
    }
}
