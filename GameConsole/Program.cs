using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();
            player.Name = "vsl";
            player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;

            Console.WriteLine(days);

            PlayerDisplayer.Write(player);
        }
    }
}
