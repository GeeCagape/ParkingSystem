using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSystem
{
    class ParkingSlot
    {
        int SlotNum;

        public SlotAvailability Status { get; set; }

        public ParkingSlot()
        {

            this.SlotNum = slotNum;


        }

        public ParkingSlot(SlotAvailability status)
        {
            this.Status = status;

            switch (this.Status)
            {
                case SlotAvailability.Open: Console.WriteLine("You can park here");
                    break;
                case SlotAvailability.Occupied: Console.WriteLine("You can't park here");
                    break;
            }
        }

        
    }
}