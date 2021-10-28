using System;
using gb_OOP_HW_4;

namespace gb_OOP_HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuilding(30, 8, 99);
            Creator.CreateBuilding(30, 8, 99);
            Creator.CreateBuilding(30, 8, 99);
            Creator.CreateBuilding(30, 8, 99);

            //работает если в одной сборке
            //var home = new Building(30, 8, 99, 2); 
            //Creator.AddBuilding(home);

            //Если Building в другой сборке то консруктор не доступен.
            //Экземпляр класса, можно создать только при помощи фабрики
            var home = Creator.CreateBuilding(30, 8, 99, 2); 

            Console.WriteLine("Список Id всех созданных зданий");
            foreach(Building b in Creator.Buildings.Values)
            {
                Console.WriteLine(b.Id);
            }
            var homeHash = home.GetHashCode();
            Console.WriteLine($"Хэш код здания home = {homeHash}");

            Console.WriteLine($"Удаление здания из таблицы по Хэш-коду");
            Creator.RemoveBuilding(homeHash);

            Console.WriteLine("Список Id всех оставшихся зданий");
            foreach (Building b in Creator.Buildings.Values)
            {
                Console.WriteLine(b.Id);
            }
        }
    }
}
