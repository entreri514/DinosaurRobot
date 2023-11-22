using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurRobot
{
    internal class Dinosaur
    {
        public string dinosaurName;
        public int dinoHealth;
        public int dinoAttackPower;

        public Dinosaur(string dinoName)
         {
            dinoHealth = 100;
            dinoAttackPower = 12;
            dinosaurName = dinoName; 
         }
        
        

    }
}
