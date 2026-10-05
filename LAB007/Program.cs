/*
 * Student ID : 1690703200
 * Name       : Chainapat Sakun
 * Section    : 129C
 * No.        : 29
 * Course     : GI113 Computer Programming (GI)
 */
namespace LAB007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            const int GoblinHp = 15;

            Console.Write("Goblin Armor: ");
            int.TryParse(Console.ReadLine(), out int goblinArmor);
            Console.WriteLine($"A wild Goblin appears! HP {GoblinHp}, ARMOR {goblinArmor}");

            Console.WriteLine("=== THE KING GOBLIN ===");
            Console.WriteLine("1) Heavy Slash");
            Console.WriteLine("2) Lightning Bolt");
            Console.WriteLine("3) Block");
            Console.WriteLine("4) Retreat");
            Console.WriteLine("5) Poison Dart"); 
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Knight delivers a heavy slash with a greatsword!");
                    break;
                case 2:
                    Console.WriteLine("Knight channels a striking Lightning Bolt!");
                    break;
                case 3:
                    Console.WriteLine("Knight holds the ground with an iron shield.");
                    break;
                case 4:
                    Console.WriteLine("Knight steps back to analyze the enemy...");
                    break;
                case 5: 
                    Console.WriteLine("Knight shoots a toxic Poison Dart!");
                    break;
                default:
                    Console.WriteLine("Knight loses focus. Invalid action!");
                    break;
            }

            int power = command switch
            {
                1 => 14,
                2 => 19,
                5 => 16, 
                _ => 0
            };

            int damage = Math.Max(0, power - goblinArmor);
            Console.WriteLine($"Damage Dealt: {damage}");

            string rating = damage switch
            {
                >= 12 => "Devastating strike!",
                >= 5 => "Good hit.",
                > 0 => "Glancing blow.",
                _ => "Blocked completely."
            };
            Console.WriteLine($"Strike Rating: {rating}");

            string goblinStatus = damage >= GoblinHp ? "ELIMINATED" : "still fighting";
            Console.WriteLine($"Goblin Status: {goblinStatus}");

            Console.Write("Really retreat from battle? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You successfully retreated!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stand firm and continue the fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n correctly.");
                    break;
            }
        }
    }
}
