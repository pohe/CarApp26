using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp26
{
    public class Renter
    {
        public string Name
        {
            get;
            set;
        }

        //auto property - har et skjult instance field
        public string Address
        {
            get;
            set; 
        }

        public string DriverLicenseNo
        {
            get;
            set; 
        }
        public Renter(string name, string address, string driverLicenseNo)
        {
            Name = name;
            Address = address;
            DriverLicenseNo = driverLicenseNo;
        }

        //returnerer en tekststreng der beskriver tilstanden (værdier) af objektet. 
        public override string ToString() 
        {
            return $"Name {Name} address {Address} driverlicenseno {DriverLicenseNo}";
        }

    }
}
