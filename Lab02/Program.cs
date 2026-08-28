/*
 * Student ID :1690703200
 * Name       :Lab02
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine();
            // คำนวณเปอร์เซ็น
            int hpPerent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPerent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            // ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            currentHp = currentHp *100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPerent}%") ;

            // Part B

            //ตัวละครที่1 นักรบ (Warrior)

            string character1Name = "Salmon";
            int character1Hp = 600;
            double character1Attack = 30.50;
            float character1Speed = 20.50f;
            char character1Rank = 'S';
            bool character1IsAlive = true;

            //ตัวที่2 นักเวท (Mage)

            string character2Name = "Nimo";
            int character2Hp = 400;
            double character2MagicPower = 50.25;
            float character2Casttime = 1.2f;
            char character2Rank = 'A';
            bool character2IsAlive = true;

            //ตัวที่3 โจร (Rogue)

            string character3Name = "Tuna";
            int character3Hp = 550;
            double character3Stamina = 100.0;
            float character3CritRate = 30.5f;
            char character3Rank = 'A';
            bool character3IsAlive = true;

            //คัวละครที่4 นักบวช (Cleric)

            string character4Name = "Shark";
            int character4HP = 450;
            double character4HealPower = 70f;
            float character4Cooldown = 2.5f;
            char character4Rank = 'A';
            bool character4IsAlive = true;


            //ตัวที่1
            Console.WriteLine($"Character 1 Salmon: {character1Name}");
            Console.WriteLine($"Character 1 HP: {character1Hp}");
            Console.WriteLine($"Character1 Attack: {character1Attack}");
            Console.WriteLine($"Character1 Speed: {character1Speed}");
            Console.WriteLine($"Character 1 Rank: {character1Rank}");
            Console.WriteLine($"Character 1 Is Alive: {character1IsAlive}");
            Console.WriteLine();

            //ตัวที่2
            Console.WriteLine($"Character 2 Nimo: {character2Name}");
            Console.WriteLine($"Character 2 HP {character2Hp}");
            Console.WriteLine($"Character 2 Magicpower: {character2MagicPower}");
            Console.WriteLine($"Character 2 Cast Time: {character2Casttime}");
            Console.WriteLine($"Character 2 Rank: {character2Rank}");
            Console.WriteLine($"Character 2 Is Alive: {character2IsAlive}");
            Console.WriteLine();

            //ตัวที่3
            Console.WriteLine($"Character 3 Tuna: {character3Name}");
            Console.WriteLine($"Character 3 HP: {character3Hp}");
            Console.WriteLine($"Character 3 Stamina: {character3Stamina}");
            Console.WriteLine($"Character 3 Crit Rate:{character3CritRate}%");
            Console.WriteLine($"Character 3  Rank: {character3Rank}");
            Console.WriteLine($"Character 3 Is Alive: {character3IsAlive}");
            Console.WriteLine();

            //ตัวที่4
            Console.WriteLine($"Character 4 Shark: {character4Name}");
            Console.WriteLine($"Character 4 HP: {character4HP}");
            Console.WriteLine($"Character 4 HealPower: {character4HealPower}");
            Console.WriteLine($"Character 4 Cooldown: {character4Cooldown}");
            Console.WriteLine($"Character 4 Rank: {character4Rank}");
            Console.ReadLine();
        }
    }
}
