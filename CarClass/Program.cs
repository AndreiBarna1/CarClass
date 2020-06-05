using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.name = "Q7";
            car.price = 3000000;
            car.age = 1;
            car.place = "Германия";

            car.GetCarInfo();

            Car1 car1 = new Car1();
            car1.type = "Купэ";
            car1.name = "Porshe cayman";
            car1.place = "Германия";
            car1.price = 5200000;
            car1.age =  3;


            car1.GetCar1Info();

            Console.ReadLine();
        }
    }
}
