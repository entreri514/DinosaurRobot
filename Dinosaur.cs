using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Dinosaur
    {
        public string DinosaurName;
        public int DinosaurHealth = 100;
        public int DinosaurAttackPower = 12;

        public Dinosaur()
         {
            string givenName;
        Console.WriteLine("Please enter the name of the Dinosaur: ");
            givenName = Console.ReadLine();
            DinosaurName = givenName; 
         }
        
        

    }
}
