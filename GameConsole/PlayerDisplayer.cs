using System;
namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine($"Player Name: {player.Name}");

            if (player.DaysSinceLastLogin == -1)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine($"Days since last login: {player.DaysSinceLastLogin}");
            }

            if (player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("No date specified for birthdate");
            }
            else
            {
                Console.WriteLine($"Player's birthdate: {player.DateOfBirth}");
            }
        }
    }
}
