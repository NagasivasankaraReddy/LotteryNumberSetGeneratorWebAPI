using LotteryNumberSetGenerator.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LotteryNumberSetGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotteryNumberSetController : ControllerBase
    {
        private readonly IGenerateuniqueLotterySets _generateuniqueLotterySets;

        public LotteryNumberSetController(IGenerateuniqueLotterySets generateuniqueLotterySets)
        {
            _generateuniqueLotterySets = generateuniqueLotterySets;
        }

        [HttpGet("generate")]
        public ActionResult Generate(int numberOfSets = 1)
        {
            List<string> lotteryNumbers = new List<string>();
 
            var result = _generateuniqueLotterySets.GetUniqueLotterySets(numberOfSets);
            foreach(var set in result)
            {
                StringBuilder lotteryNumber = new StringBuilder();
                foreach(int number in set)
                {
                    lotteryNumber.Append(number.ToString("D2"));
                }
                lotteryNumbers.Add(lotteryNumber.ToString());
            }

            return Ok(lotteryNumbers);
        }
    }
}
