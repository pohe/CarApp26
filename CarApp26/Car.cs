using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp26
{
    public class Car
    {
        //Instance fields
        private string _brand;
        private string _model;
        private int _year;
        private string _regNo;
        private bool _trackReady;
        private Owner _owner;
        private int _odometer;

        private static readonly Random _rand = new Random();

        public Car( string brand, string model, int year, string regNo, bool trackReady, Owner owner )
        {
            _brand = brand;
            _model = model;
            _year = year;
            _regNo = regNo;
            _trackReady = trackReady;
            _owner = owner;
            _odometer = 0;
        }


        public Car()
        {
            _brand = "Brand";
            _model = "Model";
            _year = 1970;
            _regNo = "xxxxxx";
            _trackReady = false;

            _owner = new Owner();
            _odometer = 0;
        }


        public string Brand
        {
            get { return _brand; }
            set { _brand = value;  }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int  Year
        {
            get { return _year; }
            set { _year = value;  }
        }

        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value;  }
        }

        public bool TrackReady
        {
            get { return _trackReady; }
            set { _trackReady = value;  }
        }

        public Owner TheOwner
        {
            get { return _owner; }
        }

        public int Odometer
        {
            get { return _odometer; }
        }
        public void Drive()
        {
            int km = _rand.Next(1, 101);
            _odometer = _odometer + km; //_odometer += km; 
            Console.WriteLine("km " + km);
            Console.WriteLine("Odometer " + _odometer );
            Console.WriteLine($"Brand {_brand} regno {_regNo}  kilometertæller { _odometer }");
        }


        public void Start()
        {
            Console.WriteLine("Bilen er startet");
        }

        public void PrintAllINformation()
        {
            Console.WriteLine($"Brand {_brand} model {_model} year {_year} regNo {_regNo} trackReady {_trackReady} owner {_owner.Name} cpr på owner {_owner.Cpr} ");
            //_owner.PrintOwnerInfo();
        }

        public void ChangeOwner( Owner newOwner )
        {
            _owner = newOwner;
        }
    }
}
