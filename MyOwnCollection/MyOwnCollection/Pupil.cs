using System;

namespace MyOwnCollection
{
    /// <summary>
    /// Ученик.
    /// </summary>
    class Pupil : IHuman
    {
        /// <summary>
        /// Класс ученика.
        /// </summary>
        private int grade;
        public string Name { get; set; }
        public string Surname { get; set; }
        /// <summary>
        /// Свойство доступа к классу ученика.
        /// </summary>
        public int Grade {
            get => grade;
            set
            {
                if (value > 0 && value <= 11)
                    grade = value;
                else if(value <= 0)
                    throw new ArgumentException("The grade can't be 0 or less", nameof(value));
                else
                    throw new ArgumentException("The grade can't be over 11", nameof(value));
            }
        }
        public Pupil(string name, string surname, int grade)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
        }
        public override string ToString() => String.Format($"{Name} {Surname}, Grade {Grade}");
    }
}
