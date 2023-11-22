using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Robot
    {
        public int roboHealth;
        public Weapon activeWeapon;
        public string robotName;
        public Robot(string roboName)
        {
            roboHealth = 100;
            robotName = roboName;
            activeWeapon = new Weapon();
        }
    }       
}
