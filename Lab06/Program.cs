/*
 * Student ID : 1690703200
 * Name       : Chainapat Sakun
 * Section    : 129C
 * No.        : 29
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          //LAB 06    //ผู้เล่นโจมตีมอนเตอร์เลือดลดหรือตายมอนเตอร์โจมตีกลับผู็เล่นเลือดลดและสามารถเพิ่มเลือดได้


            int playerHp   = 500;
            int monsterHp  = 500;
            int playerAtk  = 500;
            int monsterAtk = 500;
            

            Console.WriteLine("== Battle ==");
            Console.WriteLine("Player vs. monster:");
            Console.WriteLine("ACTION 1: playerAttack");
            Console.WriteLine("ACTION 2: monsterAttack");

            Console.WriteLine("Choose your action (1-2):");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!userInput || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid action");
            }
            else if (choice == 1)
            {
                monsterHp -= playerAtk;
                Console.WriteLine($"You attacked the monster! Monster HP: {monsterHp}");
            }
            else if (choice == 2)
            {
                playerHp -= monsterAtk;
                Console.WriteLine($"The monster attacked you! Player HP: {playerHp}");
            }

            playerHp -= playerAtk;
            if (playerHp <= 0)
            {
                Console.WriteLine("You have been defeated!");
            }
            else if (monsterHp <= 0)
            {
                Console.WriteLine("You have defeated the monster!");
            }

        }
    }
}
