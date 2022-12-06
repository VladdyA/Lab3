using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Натисніть любу кнопку для того щоб побачити дані про Car");
            Console.ReadKey();

            Car car1 = new Car("Audi", "A6", "Black", 14600);
            Car car2 = new Car("Voltswagen", "Passat B5", "Silver", 12500);
            Car car3 = new Car("BMW", "528", "Blue", 13400);

            car1.Print();
            car1.ChangePrice(10);
            car1.Print();

            car2.Print();
            car2.ChangePrice(10);
            car2.Print();

            car3.Print();
            car3.ChangePrice(10);
            car3.Print();

            Console.WriteLine(car1 == car2);
            Console.WriteLine(car2 == car3);
        }
    }
}