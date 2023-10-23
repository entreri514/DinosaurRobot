using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Robot
    {
        public string RobotName;
        public int RobotHealth;

        public Robot()
        {
            string givenName;
            Console.WriteLine("Please enter the name of the robot: ");
            givenName=Console.ReadLine();
            RobotName = givenName;
            RobotHealth = 100;
            
            
        }
    }       
}
