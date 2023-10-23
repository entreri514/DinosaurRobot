using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Weapon
    {
        public string activeWeapon;
        public int WeaponAttackPower;
        public Weapon()
        {
            string weapon;
            Console.WriteLine("Please enter the type of weapon the robot posseses: ");
            weapon = Console.ReadLine();
            this.activeWeapon = weapon;
            WeaponAttackPower = 12;


        }






    }
}
