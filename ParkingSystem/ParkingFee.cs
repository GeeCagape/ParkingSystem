using System;

namespace ParkingSystem
{
    class ParkingFee
    {
        int ParkingFeeID;
        string ParkingFeeAmount;

        public ParkingFeeStatus Status { get; set; }
        public ParkingType Type { get; set; }

        public ParkingFee()
        {
            this.ParkingFeeID = feeId;
            this.ParkingFeeAmount = feeAmount;
            this.ParkingType= feeType;
            this.ParkingFeeStatus = feeStatus;
        }

        public ParkingFee(ParkingFeeStatus status)
        {
            this.ParkingFeeStatus = status;

            switch (this.ParkingFeeStatus)
            {
                case ParkingFeeStatus.Paid: Console.WriteLine("Paid");
                    break;
                case ParkingFeeStatus.Pending: Console.WriteLine("Pending");
                    break;
            }
        }

        public ParkingFee(ParkingType type)
        {
            this.ParkingType = type;

            switch (this.ParkingFeeType)
            {
                case ParkingFeeType.OneHour: Console.WriteLine("Parking for 1 hour ONLY");
                    break;
                case ParkingFeeType.ThreeHours: Console.WriteLine("Parking for 3 hours ONLY");
                    break;
                case ParkingFeeType.FiveHours: Console.WriteLine("Parking for 5 hours ONLY");
                    break;
                case ParkingFeeType.Overnight: Console.WriteLine("Parking Overnight");
                    break;
            }
        }
    }
}