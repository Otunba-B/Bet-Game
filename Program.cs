using System;

namespace Bet_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            BetPlayer player = new BetPlayer() { Name = "The Player", Cash = 100 };

            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet? ");
                var howMuch = Console.ReadLine();

                if(int.TryParse(howMuch, out int amount))
                {
                    var pot = player.GiveCash(amount) * 2;

                    if(pot > 0)
                    {
                        if(random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You won " + winnings);
                            player.ReceiveCash(winnings);

                        }

                        else
                        {
                            Console.WriteLine("Bad luck. You lose! ");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Enter an valid amount to bet");
                }
            }
            Console.WriteLine("The House always wins");
        }
    }
}
