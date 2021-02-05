using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();

            myBird.WingColor = "red";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.5;




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Lizard = new Reptile()
            {
                IsColdBlooded = true, IsScaly = true, Habitat = "swamp", CanGrowTail = true
            };

            var myAnimal = new Animal[] { myBird, Lizard };

            foreach (var Animal in myAnimal)
            {
                Console.WriteLine($"Alive: {Animal.IsAlive}");
                Console.WriteLine($"Age: {Animal.Age} years old");
                Console.WriteLine($"It has {Animal.LegCount} legs");
                Console.WriteLine($"It lives by {Animal.LandSeaAir} ");
                Console.WriteLine($"");




            }
        }
    }
}
