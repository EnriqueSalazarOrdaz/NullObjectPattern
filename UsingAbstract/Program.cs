using System;

namespace UsingAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter jose = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Jose"
            };

            PlayerCharacter pepe = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Pepe"
            };

            PlayerCharacter juan = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Juan"
            };

            jose.Hit(50);
            pepe.Hit(50);
            juan.Hit(50);
            Console.ReadLine();
        }
    }
}
