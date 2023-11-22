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
        public Dinosaur dinosaur;
        public Robot robot;

        public Battlefield()
        {
            DisplayWelcome();
            Console.WriteLine("Please enter the name of dinosaur: ");            
            dinosaur = new Dinosaur(Console.ReadLine());
            Console.WriteLine("Please enter the name of robot: ");
            robot = new Robot(Console.ReadLine());
        }
        public void DisplayWelcome()
        {
           Console.WriteLine("Welcome to Dinosaur vs Robot!");
        }

        public void Battle()
        {
            while (dinosaur.dinoHealth > 0 && robot.roboHealth > 0)
            {
                Console.WriteLine(dinosaur.dinosaurName + " attacks " + robot.robotName + " for " + dinosaur.dinoAttackPower + " points of damage.");

                robot.roboHealth = robot.roboHealth - dinosaur.dinoAttackPower;

                if (robot.roboHealth < 1)
                {
                    Console.WriteLine(robot.robotName + " dies.");
                }
                if (robot.roboHealth > 0)
                {
                    Console.WriteLine(robot.robotName + " attacks " + dinosaur.dinosaurName + " with " + robot.activeWeapon.activeWeaponName + " for " + robot.activeWeapon.weaponAttackPower + " points of damage.");

                    dinosaur.dinoHealth = dinosaur.dinoHealth - robot.activeWeapon.weaponAttackPower;
                }
                if (dinosaur.dinoHealth < 1)
                {
                    Console.WriteLine(dinosaur.dinosaurName + " dies.");
                }
            }
        }

        public void DisplayWinner()
        {
            if (robot.roboHealth < 1) Console.WriteLine(dinosaur.dinosaurName + " Wins!");
            if (dinosaur.dinoHealth < 1) Console.WriteLine(robot.robotName + " Wins!");
        }
        public void RunGame()
        {
            Battle();
            DisplayWinner();
               




                











        }        

       
    }
    
}
