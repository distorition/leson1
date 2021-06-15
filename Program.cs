using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гик_Бреинс_курсы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввидите имя");
            var name = Console.ReadLine();
            Console.WriteLine($"Дарова {name} сегодня {DateTime.Now}");
        }
    }
}
