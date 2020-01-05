using System;
namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player's name is null or all whitespace");
            }
            else
            {
                Console.WriteLine($"Player Name: {player.Name}");
            }

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine($"Days since last login: {player.DaysSinceLastLogin.Value}");
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date specified for birthdate");
            }
            else
            {
                Console.WriteLine($"Player's birthdate: {player.DateOfBirth}");
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
