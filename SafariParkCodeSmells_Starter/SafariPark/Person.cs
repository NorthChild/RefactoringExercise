using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Person
    {

        private string _firstName;
        private string _lastName;
        private int _age;

        private Address _address;

        //private string _hobbies;

        //private int _houseNo;
        //private string _street;
        //private string _town;

        public Person() { }
        public Person(string fName, string lName, Address address = null)
        {
            _firstName = fName;
            _lastName = lName;
            //_houseNo = hNo;
            //_street = street;
            //_town = town;
            if (address == null)
            {
                new Address(0, "", "");

            }
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            return "Walking along";
            //Console.WriteLine("Can't get here");
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override string ToString()
        {
            var addressString = $"Address: {_address}";
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}.{addressString}";
        }
    }
}
