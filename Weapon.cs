using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Weapon
    {
        public string activeWeaponName;
        public int weaponAttackPower;
        public Weapon()
        {
            Console.WriteLine("Please enter the type of weapon the robot posseses: ");
            activeWeaponName = Console.ReadLine();
            weaponAttackPower = 12;


        }






    }
}
