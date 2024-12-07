using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using KlassTask._01._12.Exceptions;

namespace KlassTask._01._12.WeaponModels
{
    public class Weapon
    {
        private static  int _maxammocapacity;
        private static int _currentammo;


        public static  int MaxAmmoCapacity
        {
            get => _maxammocapacity;
            set
            {
                if (value < 0)
                {

                    throw new InvalidAmmoException("MaxAmmo can not be Negative");

                }


                else if (value>0)
                {
                    _maxammocapacity = value;
                }

            }
        }
        public static int CurrentAmmo
        {
            get => _currentammo;
            set
            {
                if (value >= 0 && value <= _maxammocapacity)
                {
                    _currentammo = value;
                }
                else if (value<=0 || value>=_maxammocapacity)
                {
                    throw new InvalidCurrentAmmoException("Ammo can not be negativ and over Max ammo");
                }


            }
        }



        public static WeaponModeEnum ShootMode { get; set; }
        public Weapon(int maxammocapacity, int currentammo, int shootmood)
        {
            MaxAmmoCapacity = maxammocapacity;
            CurrentAmmo = currentammo;
            ShootMode = (WeaponModeEnum)shootmood;
        }


        public override string ToString()
        {
            return $"AmmoCapacity: {MaxAmmoCapacity},   CurrentAmmo:{CurrentAmmo},    ShootMood:{ShootMode}";
        }
        public void Shoot()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo -= 1;


            }
            else
            {
                Console.WriteLine("There is no ammo");
            }
        }


      

        public  void Changecapacity(int value)
        {
            if (value >0)
            {

               MaxAmmoCapacity=value;
            }else if (value <0)
            {
                throw new WrongOperationException("Wrong operation. Sellect number over zero");
            }
            
            
        }
        public  static void ChangeCurrentammo(int value)
        {
            if (value >= 0 && value <= MaxAmmoCapacity)
            {
                CurrentAmmo = value;
            }
           else if ( value>=MaxAmmoCapacity)
            {
                throw new OverMaxAmmoException($"Current Ammo can not be over Max Ammo:You Max Ammo {MaxAmmoCapacity}");
            }else if (value<=0)
            {
                throw new WrongOperationException("Wrong operation.Sellect number over zero");
            }
            
            
            
           
        }
        public void Fire()
        {


            if (ShootMode == WeaponModeEnum.Shoot)
            {
                _currentammo -= 1;

            }
            else if (ShootMode == WeaponModeEnum.Burst)
            {
                _currentammo -= 3;
            }
            else if (ShootMode == WeaponModeEnum.Fire)
            {

                _currentammo = 0;
            }
            else
            {
                Console.WriteLine("There is no ammo");
            }



        }

        public void Brust()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo -= 3;

            }
            else
            {
                Console.WriteLine("There is no ammo");
            }
        }
        public int GetRemainBulletCount()
        {
            var remainbulletcount = MaxAmmoCapacity - CurrentAmmo;
            Console.WriteLine($"You need {remainbulletcount} ammo ");
            return remainbulletcount;
        }
        public void Reload()
        {
            CurrentAmmo = MaxAmmoCapacity;
            Console.WriteLine("Reloading");
        }

        public static void ChangeFireMode(int num)
        {
            if (num > 0 && num < 4)
            {
                if (num == 1)
                {
                    ShootMode = WeaponModeEnum.Shoot;
                }
                else if (num == 2)
                {
                    ShootMode = (WeaponModeEnum.Burst);
                }
                else if (num == 3)
                {
                    ShootMode = WeaponModeEnum.Fire;
                }
            }
                else
                {
                    Console.WriteLine("There is not mood like that");
                }

        }

    }
}
