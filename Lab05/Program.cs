namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> GAME KAK <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");

            // Hero stats input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);

            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);

            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);


            // Monster stats input
            Console.Write("Monster Health: ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);

            Console.Write("Monster Attack: ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);

            Console.Write("Monster Defense: ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

            // input validation
            bool inHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonInputValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {inHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonInputValid}");

            Console.WriteLine($"[HERO]     HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]  HP: {monsterHp} ATK: {monsterAtk} DEF:{monsterDef}");
            //bool allIntValid = !inHeroIntValid && isMonInputValid;
            // ถ้าเอาแค่ชื่อ bool มาเช็ค คือ เช็คว่าเป็นจริงมั้ย? แต่ถ้าใส่ ! ด้านหน้าคือตรงข้าม (จริง -> เท็จ)



            // Compound assignment : +=
            int potion = 8;
            //heroHp = heroHp + potionHeal; //แบบยาว
            heroHp += potion;           //แบบสั้น ความหมายเดียวกัน นำ potion มา+กับ heroHp heroHp
            Console.WriteLine($"\nHero drinks a potion, Healing {potion} HP. Hero HP now {heroHp} HP");

            // Arithmetic + การโจมตีธรรมดา
            int normDmg = Math.Max(0, heroAtk - monsterDef); // ความแรงการโจมจีขึ้นอยู่กับค่าป้องกันศัตรู
            Console.WriteLine($"\nNormal Attack would deal: {normDmg} DMG");

            // Precedence
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monsterDef); // โจมตีคูณ 2 จะใส่วงเล็กหรือไม่ก็ได้เพราะทำคูณก่อน
            Console.WriteLine($"Power Attack would deal: {pwrDmg} DMG");

            // Random, Simple precent chance
            Random random = new Random();
            int roll = random.Next(1, 101); //ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้อง 101
            bool isCrit = roll <= 10; // 10% Chance จาก 100
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg; // Bool 1 หรือ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If critical, normal attack woud instead deal: {critDmg}");
        }
    }
}
