using System;
using System.Collections;
using System.Collections.Generic;


namespace MyOwnCollection
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    public class LinkedList<T> :IEnumerable<T>
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Количество элементов в списке.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Создание пустого списка.
        /// </summary>
        public LinkedList(){
            Clear();
        }
        /// <summary>
        /// Создание списка с одним элементом.
        /// </summary>
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }
        /// <summary>
        /// Добавить элемент в начало списка
        /// </summary>
        public void AddFirst(T data)
        {
            var item = new Item<T>(data);
            if (Head == null)
            {
                SetHeadAndTail(item);
                return;
            }
            item.Next = Head;
            Head = item;
            Count++;
        }
        /// <summary>
        /// Добавление нового элемента списка в конец.
        /// </summary>
        public void AddLast(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }
        /// <summary>
        /// Добавляет элемент после указанного элемента
        /// </summary>
        public void AddAfter(T target, T data)
        {
            var current = Head;
            while(current!= null)
            {
                if (current.Data.Equals(target))
                {
                    var item = new Item<T>(data);
                    item.Next = current.Next;
                    current.Next = item;
                    if (current.Equals(Tail))
                        Tail = item;

                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }           
        }

        /// <summary>
        /// Удаление элемента из списка.
        /// </summary>
        /// <param name="data">элемент, который будет удалён</param>
        public void Remove(T data)
        {
            if(Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    if (Head.Next == null)
                        Clear();
                    else
                    {
                        Head = Head.Next;
                        Count--;
                    }
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while(current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if(current.Equals(Tail))
                            Tail = previous;
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;

                }
            }
        }
        /// <summary>
        /// Удаление по элемента по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        public void RemoveAt(int index)
        {
            if (Head != null)
            {
                int indexer = 0;
                if (indexer == index)
                {
                    if (Head.Next == null)
                        Clear();
                    else
                    {
                        Head = Head.Next;
                        Count--;
                    }
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                indexer++;
                while(current != null)
                {
                    if(indexer == index)
                    {
                        if (current.Equals(Tail))
                            Tail = previous;
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    indexer++;
                    previous = current;
                    current = current.Next;
                }
            }
        }
        /// <summary>
        /// Полностью очищает список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Выводит на экран элементы списка
        /// </summary>
        public static void Print(LinkedList<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Устанавливает "Голову" и "Хвост" списка.
        /// </summary>
        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator();

        public override string ToString() => String.Format($"Linked List, count of elements: {Count}");
    }
}
