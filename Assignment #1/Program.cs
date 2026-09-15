/*
 * Student ID : 1690703200
 * Name       : Chainapat Sakun
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "VALORANT";

            var agentName = "Jett";
            var agentTier = "S";


            string agentRole = "Duelist";
            char currentRank = 'S';
            int agentLevel = 50;
            float headshotRate = 50.0f;
            double averageCombatScore = 150.5;
            bool isUltimateReady = true;
            double levelAsDouble = agentLevel;
            int acsTruncated = (int)averageCombatScore;
            int acsRounded = Convert.ToInt32(averageCombatScore);



            Console.WriteLine("==================================================");
            Console.WriteLine($"               ! {GameTitle}  !                  ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"║ Agent Name    : {agentName} ");
            Console.WriteLine($"║ Role          : {agentRole}");
            Console.WriteLine($"║ Tier Rank     : {currentRank} ");
            Console.WriteLine($"║ Account Level : {agentLevel} ");
            Console.WriteLine($"║ Headshot Rate : {headshotRate}% ");
            Console.WriteLine($"║ Avg Combat Score: {averageCombatScore} ");
            Console.WriteLine($"║ Ultimate Ready: {isUltimateReady} ");
            Console.WriteLine("==================================================");
            Console.WriteLine();


            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.WriteLine("│               CONVERSION RESULT                │");
            Console.WriteLine("├────────────────────────────────────────────────┤");
            Console.WriteLine($"│ Level as double (implicit) : {levelAsDouble}");
            Console.WriteLine($"│ ACS (explicit cast / cuts) : {acsTruncated}");
            Console.WriteLine($"│ ACS (Convert / rounds)     : {acsRounded}");
            Console.WriteLine("└────────────────────────────────────────────────┘");




            Console.WriteLine(@" \ \   / / ");
            Console.WriteLine(@"  \ \ / / ");
            Console.WriteLine(@"   \ V / ");
            Console.WriteLine(@"    \_/");
            Console.WriteLine();












        }
    }
}
