using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_OOP_HW_4
{
    public class Creator
    {
        private Creator() { }
        public static  Hashtable Buildings = new();

        public static Building CreateBuilding(double height, int floorCount, int roomCount, int entranceCount)
        {
            var result = new Building(height, floorCount, roomCount, entranceCount);
            Buildings.Add(result.GetHashCode(), result);
            return result;
        }

        public static Building CreateBuilding(double height, int floorCount, int roomCount)
        {
            var result = new Building(height, floorCount, roomCount,1);
            Buildings.Add(result.GetHashCode(), result);
            return result;
        }

        public static void RemoveBuilding(int hashCode)
        {
            Buildings.Remove(hashCode);
        }
        public static void AddBuilding(Building building)
        {
            Buildings.Add(building.GetHashCode(), building);
        }
    }
}
