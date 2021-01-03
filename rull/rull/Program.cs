using System;

namespace rull
{
    class Program
    {
        private static int amound { get; set; } = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JT Casino");
            Console.WriteLine($"Balance is : {amound}$");
            while (true)
            {
                Console.WriteLine("Make your bets ladies and gentlemen");
                int userBetAmound;
                try
                {
                    userBetAmound = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
                if (userBetAmound > amound || userBetAmound <= 0)
                {
                    continue;
                }
                Console.WriteLine("Choose RED or BLACK");
                string userСhoice = Console.ReadLine().ToUpper();
                switch (userСhoice)
                {
                    case "RED":
                        amound += Processor(0, userBetAmound);
                        break;
                    case "BLACK":
                        amound += Processor(1, userBetAmound);
                        break;
                    default:
                        continue;
                }
                Console.WriteLine($"Balance now is : {amound}$");
            }
        }
        static int State()
        {
            Random random = new Random();
            int state = random.Next(0, 2);
            return state;
        }
        static int Processor(int state, int betAmound)
        {
            int stateResult = State();
            if (state == stateResult)
            {
                Console.WriteLine($"Ваша ставка сыграла, выйгрышь: {betAmound}");
                return betAmound;
            }
            else
            {
                Console.WriteLine($"Ваша ставка не сыграла, потеря: {betAmound}");
                return -betAmound;
            }
        }
    }
}