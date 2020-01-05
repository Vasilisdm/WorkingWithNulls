using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();
            player.Name = "vsl";

            PlayerDisplayer.Write(player);
        }
    }
}
