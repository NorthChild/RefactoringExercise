using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Hunter : BaseClass, IShootable
    {
        public IShootable Shooter { get; set; }
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            var fullNameVar = GetFullName();
            if (Shooter == null)
            {
                fullNameVar += " doesn't have a shooter";
            }
            else
            {
                fullNameVar += $": { Shooter.Shoot()}";
            }
            return fullNameVar;
        }

        public override string ToString()
        {
            var msg = base.ToString();
            if (Shooter != null)
            {
                msg += $" Shooter: {Shooter}";
            }
            return msg;
        }
    }
}
