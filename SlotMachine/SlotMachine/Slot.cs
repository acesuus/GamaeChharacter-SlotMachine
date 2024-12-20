using System;
using System.Linq;

namespace SlotMachine.Models
{
    public class Slot
    {
        public Reel[] Reels { get; }
        private static readonly Random random = new Random();
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            this.balance = initialBalance;
            this.reels = reels;
        }

        public int Balance
        {
            get => balance;
            set => balance = value;
        }

        public int Stake
        {
            get => stake;
            set => stake = value;
        }

        // Spin each reel and update the corresponding PictureBox with a new image
        public void Spin()
        {
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        // Check the result of the spin to determine if there are winnings
        public int CheckResult()
        {
            // Get the images currently displayed on each reel
            var results = reels.Select(reel => reel.GetCurrentImage()).ToArray();

            // Check if all the images are the same
            if (results.Distinct().Count() == 1)
            {
                // All three images are the same, player wins
                return stake * 10; // Example payout multiplier
            }

            // Check for two matching images
            if (results.GroupBy(x => x).Any(g => g.Count() == 2))
            {
                // Two images are the same, player wins a smaller amount
                return stake * 2; // Example payout multiplier
            }

            // No matching images, player loses
            return 0;
        }

        // Update balance after a spin result
        public void UpdateBalance(int winnings)
        {
            balance += winnings;
        }
    }
}