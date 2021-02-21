using System;

namespace MyOwnCollection
{
    /// <summary>
    /// Бакалавр.
    /// </summary>
    public class Bachelor : IHuman
    {
        /// <summary>
        /// Курс на котором учится студент.
        /// </summary>
        private int year;
        public string Name { get; set; }
        public string Surname { get; set; }
        /// <summary>
        /// Свойство доступа к курсу на котором учится студент.
        /// </summary>
        public int Year
        {
            get => year;
            set
            {
                if(value > 0 && value <= 4)
                    year = value;
                else if (value <= 0)
                    throw new ArgumentException("The year can't be 0 or less", nameof(value));
                else
                    throw new ArgumentException("The year can't be over 4", nameof(value));
            }
        }
        public Bachelor(string name, string surname, int year)
        {
            Name = name;
            Surname = surname;
            Year = year;
        }
        public override string ToString()=> String.Format($"{Name} {Surname}, Year: {Year}");
    }
}
