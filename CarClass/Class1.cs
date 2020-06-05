using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Car
    {
        public double price { get; set; }
        public int age { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetCarInfo()
        {
            Console.WriteLine($"Имя: {name}| |Лет с момента покупки: {age}| |Страна производства: {place}|");
        }
    }


    class Car1 : Car
    {
        public string type { get; set; }

        public virtual void GetCar1Info()
        {
            Console.WriteLine($"Имя: {name}| |Лет с момента покупки: {age}| |Место: {place}| |Цена автомобиля: {price}| |Тип: {type}");
        }
    }
}