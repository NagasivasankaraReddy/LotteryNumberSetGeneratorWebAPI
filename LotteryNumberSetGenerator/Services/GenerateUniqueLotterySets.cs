using LotteryNumberSetGenerator.Interfaces;

namespace LotteryNumberSetGenerator.Services
{
    public class GenerateUniqueLotterySets: IGenerateuniqueLotterySets
    {
        private readonly IRandomNumberGenerator _randomNumbergenerator;

        public GenerateUniqueLotterySets(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumbergenerator = randomNumberGenerator;
        }

        public List<Array> GetUniqueLotterySets(int number)
        {
            List<Array> uniqueLotterySets = new List<Array>();

            for(int i=0; i< number; i++)
            {
                var lotteryNumber = _randomNumbergenerator.GenerateRandomLotterySet();
                if (!uniqueLotterySets.Contains(lotteryNumber))
                {
                    uniqueLotterySets.Add(lotteryNumber);
                }
            }

            return uniqueLotterySets;
        }
    }
}
