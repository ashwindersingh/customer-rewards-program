using CustomerRewards.Core.DomainModels;

namespace CustomerRewards.Core
{
    public interface ITransactionRepoistory
    {
       // List<TransactionModel> GetAllUserRewards(int customerId);
        void AddReward(TransactionModel transaction);
        List<TransactionModel> GetUserRewards(int customerId, DateTime startDate);
    }
}