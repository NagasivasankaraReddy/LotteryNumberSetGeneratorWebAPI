using LotteryNumberSetGenerator.Interfaces;

namespace LotteryNumberSetGenerator.Services
{
    public class RandomNumberGeneratorService : IRandomNumberGenerator
    {
        private readonly Random _random = new Random();

        public int[] GenerateRandomLotterySet()
        {
            int[] lotterySet = new int[6];

            for(int i=0; i<6; i++)
            {
                lotterySet[i] = _random.Next(1, 60);
            }

            return lotterySet;
        }
    }
}
