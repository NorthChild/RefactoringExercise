using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Address
    {

        public int _houseNumber;
        public string _street;
        public string _town;


        public Address(int houseNumber, string street, string town)
        {
            _houseNumber = houseNumber;
            _street = street;
            _town = town;
        }

        public override string ToString()
        {
            return $"{ base.ToString()} House Nmb: {_houseNumber}, Street: {_street}, Town: {_town} ";
        }

    }
}
