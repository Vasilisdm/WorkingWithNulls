using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter orc = new PlayerCharacter(new IronBonesDefence());
            PlayerCharacter mage = new PlayerCharacter(new DiamondSkinDefence());
            PlayerCharacter dwarf = new PlayerCharacter(null);

            orc.Hit(10);
            mage.Hit(10);
            dwarf.Hit(10);

            Console.ReadLine();
        }
    }
}
