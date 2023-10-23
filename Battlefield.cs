using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Battlefield
        
    {

        bool AWinner = false;

       
        
       
        public void DisplayWelcome()
        {
           Console.WriteLine("Welcome to Dinosaur vs Robot!");
        }

        public void RunGame()
        {

            DisplayWelcome();

            
            Dinosaur dinoOne = new Dinosaur();
            Robot roboOne = new Robot();
            Weapon weapOne = new Weapon();
            if (AWinner = false)
            {
                Console.WriteLine(dinoOne.DinosaurName + " attacks " + roboOne.RobotName + " for " + dinoOne.DinosaurAttackPower + " points of damage.");

                roboOne.RobotHealth = roboOne.RobotHealth - dinoOne.DinosaurAttackPower;

                if (roboOne.RobotHealth < 1)
                {
                    Console.WriteLine(roboOne.RobotName + " dies.");
                    AWinner = true;
                }
            }
            if (AWinner=false)
            {
                Console.WriteLine(roboOne.RobotName + " attacks " + dinoOne.DinosaurName + " with "+weapOne.activeWeapon+" for "+weapOne.WeaponAttackPower+" points of damage.");

                dinoOne.DinosaurHealth = dinoOne.DinosaurHealth - weapOne.WeaponAttackPower;

                if (dinoOne.DinosaurHealth<1)
                {
                    Console.WriteLine(dinoOne.DinosaurName + " dies.");
                }

            }
            if (AWinner = true)
            {
                if (roboOne.RobotHealth < 1) Console.WriteLine(dinoOne.DinosaurName + " Wins!");
                if (dinoOne.DinosaurHealth < 1) Console.WriteLine(roboOne.RobotName + " Wins!");
            }
            
            
                



        }

       
                
                

       
    }
    
}
