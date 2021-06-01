using System;

namespace Bet_Game
{
    public class BetPlayer
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Writes the name and the amount of cash the person has to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks. ");
        }

        /// <summary>
        /// Removes a certain amount of cash from your wallet and gives to another person.
        /// </summary>
        /// <param name="amount">Amount of cash to give. </param>
        /// <returns>
        /// The amount of cash removed from my wallet, or 0 if I don't have enough cash(or if amount is invalid).
        /// </returns>

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            }

            else if (amount > Cash)
            {
                Console.WriteLine(Name + " says " + " I don't have enough money to give you " + amount);
                return 0;
            }

            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Receives a valid amount. 
        /// </summary>
        /// <param name="amount">
        /// The amount of cash added to my purse.
        /// </param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take. ");
            }

            Cash += amount;

        }

    }
}
