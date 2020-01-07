using System;
namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (player is null)
            {
                Console.WriteLine("No player specified.");
                return;
            }

            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player's name is null or all whitespace");
            }
            else
            {
                Console.WriteLine($"Player Name: {player.Name}");
            }
        }
    }
}
