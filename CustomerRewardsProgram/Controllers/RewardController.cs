using CustomerRewards.Core;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRewardsProgram.Controllers
{
    /// <summary>
    /// This is reward controller for calcaulting the rewards
    /// </summary>
    [ApiController]
    [Route("reward")]
    public class RewardController : ControllerBase
    {
        private readonly ILogger<RewardController> _logger;
        private readonly ITransactionServices _transactionServices;

        public RewardController(ILogger<RewardController> logger, ITransactionServices transactionServices)
        {
            _logger = logger;
            _transactionServices = transactionServices;
        }

        /// <summary>
        /// Get Total User rewards user has till present day
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetUserRewards()
        {
            int customer = 100; //This can passed from the frontend for each customer or from token
            if (customer < 0) return BadRequest("Invalid Customer Id");
            var result = _transactionServices.GetTotaUserRewards(customer);
            return Ok($"Customer has Total {result} rewards points");
        }

        /// <summary>
        /// Get Rewards for the past 3 months of customer
        /// </summary>
        /// <returns></returns>
        [HttpGet("{months}")]
        public IActionResult GetThreeMonthsRewards(int months = 3)
        {
            int customer = 100; //This can passed from the frontend for each customer or from token
            var startDate = DateTime.Now.AddMonths(-3);

            if (customer < 0) return BadRequest("Invalid Customer Id");
            var result = _transactionServices.GetThreeMonthsRewards(customer, startDate);
            return Ok($"Customer has Total {result} rewards points for Past 3 months");
        }

        /// <summary>
        /// Calcualte the total reward point for the amount
        /// </summary>
        /// <returns></returns>
        [HttpGet("calculate")]
        public IActionResult CalculateRewards(int amount)
        {
            if (amount < 0) return BadRequest("Please Enter the valid Amount");
            var result = _transactionServices.CalculateRewardPoints(amount);
            return Ok(result);
        }

        /// <summary>
        /// Add the new reward based on the amount to the user
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPost("transaction")]
        public IActionResult AddRewardTransaction(int amount)
        {
            int customerId = 100; //This can passed from the frontend for each customer or from token
            if (customerId < 0) return BadRequest("Please enter the valid customer id");
            _transactionServices.AddReward(customerId, amount);
            return Ok("Reward Successfully added");
        }
    }
}