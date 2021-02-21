using System;

namespace MyOwnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var pupil1 = new Pupil("Иванов", "Иван", 8);
            var pupil2 = new Pupil("Сидоров", "Сергей", 11);
            var pupil3 = new Pupil("Андиенко", "Андрей", 9);

            var bachelor1 = new Bachelor("Лущанец", "Александр", 2);
            var bachelor2 = new Bachelor("Романов", "Антон", 4);

            var list = new LinkedList<IHuman>(pupil1);
            list.AddFirst(pupil2);
            list.AddAfter(pupil2, pupil3);
            list.AddLast(bachelor1);
            list.Remove(bachelor1);
            list.RemoveAt(1);
            list.AddLast(bachelor2);
            LinkedList<IHuman>.Print(list);
            list.Clear();

        }
    }
}
