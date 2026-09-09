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

        public Car( string brand, string model, int year, string regNo, bool trackReady )
        {
            _brand = brand;
            _model = model;
            _year = year;
            _regNo = regNo;
            _trackReady = trackReady;
        }


        public Car()
        {
            _brand = "Brand";
            _model = "Model";
            _year = 1970;
            _regNo = "xxxxxx";
            _trackReady = false; 
        }


        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int  Year
        {
            get { return _year; }
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

        public void Drive()
        {
            Console.WriteLine($"Brand {_brand} regno {_regNo}  kører");
        }


        public void Start()
        {
            Console.WriteLine("Bilen er startet");
        }

        public void PrintAllINformation()
        {
            Console.WriteLine($"Brand {_brand} model {_model} year {_year} regNo {_regNo} trackReady {_trackReady}");
        }
    }
}
