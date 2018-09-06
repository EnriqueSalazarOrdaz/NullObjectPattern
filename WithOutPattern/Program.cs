using System;

namespace WithOutPattern
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

            PlayerCharacter juan = new PlayerCharacter(null)
            {
                Name = "Juan"
            };

            jose.Hit(50);
            pepe.Hit(50);
            try { 
                juan.Hit(50);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
