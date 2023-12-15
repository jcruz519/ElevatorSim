using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSim.Models
{
    public class Passenger
    {
        public int CurrentFloor { get; set; }
        public int FloorDestination { get; set; }

        public Passenger(int currentFloor, int floorDestination)
        {
            CurrentFloor = currentFloor;
            FloorDestination = floorDestination;
        }
    }
}
