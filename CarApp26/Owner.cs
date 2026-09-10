using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp26
{
    public class Owner
    {
        //instance fields
        private string _name;
        private string _address;
        private string _cpr;


        /// <summary>
        /// Initializes a new instance of the Owner class with the specified name, address, and CPR.
        /// </summary>
        /// <param name="name">The owner's full name.</param>
        /// <param name="address">The owner's postal address.</param>
        /// <param name="cpr">The owner's CPR number.</param>
        public Owner(string name, string address, string cpr)
        {
            _name = name;
            _address = address;
            _cpr = cpr;
        }

        public Owner()
        {
            _name = "Unknown";
            _address = "No address";
            _cpr = "xxxx";
        }

        /*
         * 
         * Her er der en kommentar der 
         * går over flere linjer
         */
        public string Name
        {
            get { return _name;  }

        }


        public string Address
        {
            get { return _address;  }
            set { _address = value;  }
        }

        public string Cpr
        {
            get { return _cpr;  }
            set { _cpr = value;  }
        }


        /// <summary>
        /// Prints the owner's name, address, and CPR number to the console.
        /// </summary>
        /// <remarks>Outputs a single interpolated line with labels 'Navn', 'Adress', and 'Cpr'.</remarks>
        public void PrintOwnerInfo()
        {
            Console.WriteLine($"Navn {_name} Adress {_address} Cpr {_cpr}");
        }
    }
}
