using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public enum WeaponType
    {
        waterPistol,
        laserGun,
        bubbleGun
    }
    public class Weapon : IShootable
    {
        private WeaponType _weaponType;
        private string _brand;


        public Weapon(WeaponType type, string brand)
        {
            _weaponType = type;
            _brand = brand;
        }

        public override string ToString()
        {
            string result = $"{base.ToString()} - {_brand}";

            switch (_weaponType)
            {
                case WeaponType.waterPistol:
                    result = "Splash!! " + result;
                     break;
                case WeaponType.bubbleGun:
                    result = "Bubbles... " + result;
                    break;
                case WeaponType.laserGun:
                    result = "Zing!! " + result;
                    break;
            }
            return result;
        }

        public virtual string Shoot()
        {
            return $"Shooting a {_weaponType}";
        }
    }
}


