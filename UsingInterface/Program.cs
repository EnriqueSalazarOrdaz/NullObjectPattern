using System;

namespace UsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter jose = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Jose"
            };

            PlayerCharacter pepe = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Pepe"
            };

            PlayerCharacter juan = new PlayerCharacter(new NullDefence())
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
