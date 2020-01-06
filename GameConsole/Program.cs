using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter orc = new PlayerCharacter(new IronBonesDefence()) { Name = "Undala" };
            PlayerCharacter mage = new PlayerCharacter(new DiamondSkinDefence()) { Name = "Nuromancer" };
            PlayerCharacter dwarf = new PlayerCharacter(SpecialDefence.Null) { Name = "Balin" };

            orc.Hit(10);
            mage.Hit(10);
            dwarf.Hit(10);

            Console.ReadLine();
        }
    }
}
