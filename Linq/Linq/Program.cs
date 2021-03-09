using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            string input = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            string answer = String.Join(" ", input.Split(' ').
                Select((name, number) => String.Format($"{number+1}. {name}\n")));
            answer.ToList().ForEach(Console.Write);
            Console.WriteLine("--------------------------------------------");

            //Task2
            string input2 = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            var players = input2.Split(';')
                            .Select(p => p.Split(','))
                            .Select(p => new { Name = p[0], BirthDate = DateTime.Parse(p[1]) })
                            .Select(p => new { Name = p.Name, BirthDate = p.BirthDate, Age = p.BirthDate.GetAge() })
                            .OrderByDescending(s => s.BirthDate);
            players.Select(p=>p.Age).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("--------------------------------------------");

            //Task3
            string input3 = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            var time = input3.Split(',').Select(t => TimeSpan.Parse("0:" + t)).Aggregate((x, y) => x + y);
            Console.WriteLine($"Total duration is {time.Hours}h, {time.Minutes}m, {time.Seconds}s");

        }
        

    }
}
