using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_OOP_HW_4
{
    public class Building
    {
        private double _height;
        private int _floorCount;
        private int _roomCount;
        private int _entranceCount;

        private static int IdGenerator = 0;

        internal Building(double height, int floorCount, int roomCount, int entranceCount)
        {
            GenerateId();
            _height = height;
            _floorCount = floorCount;
            _roomCount = roomCount;
            _entranceCount = entranceCount;
            Id = IdGenerator;
        }
        private static void GenerateId()
        {
            IdGenerator++;
        }
        public int Id { get; private set; }
        public double Height { get
            {
                return _height;
            } set
            {
                _height = value;
            }
        }
        public int FloorCount {get {

                return _floorCount;
            }
            set
            {
                _floorCount = value;
            }
        }
        public int RoomCount
        {
            get
            {

                return _roomCount;
            }
            set
            {
                _roomCount = value;
            }
        }
        public int EntranceCount
        {
            get
            {

                return _entranceCount;
            }
            set
            {
                _entranceCount = value;
            }
        }

        public double GetFloorHeight ()
        {
            return Height / FloorCount;
        }
        public int GetRoomsCountInEntrance()
        {
            return EntranceCount / RoomCount;
        }
        public int GetRoomsCountOnFloor()
        {
            return GetRoomsCountInEntrance() / FloorCount;
        }

    }
}
