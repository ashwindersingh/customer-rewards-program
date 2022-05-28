
namespace CustomerRewards.Core
{
    public interface ITransactionServices
    {
        int CalculateRewardPoints(int amount);
        int GetTotaUserRewards(int customer);
        int GetThreeMonthsRewards(int customer, DateTime startDate);
        void AddReward(int customerId, int amount);
    }
}