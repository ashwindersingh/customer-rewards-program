using CustomerRewards.Core.DomainModels;
using Newtonsoft.Json;

namespace CustomerRewards.Core
{
    public class TransactionRepoistory : ITransactionRepoistory
    {
        private static List<TransactionModel> userTransactions = new();

        public TransactionRepoistory()
        {
            if(userTransactions.Count == 0)
                ReadDataSet();
        }

        public void AddReward(TransactionModel transaction) => userTransactions.Add(transaction);

        public List<TransactionModel> GetAllUserRewards(int customerId) => userTransactions.Where(_ => _.CustomerId.Equals(customerId)).ToList();

        public List<TransactionModel> GetUserRewards(int customerId, DateTime startDate) => userTransactions.Where(_ => _.CustomerId.Equals(customerId) && _.TransactionDate > startDate).ToList();
    
        private void ReadDataSet()
        {
            using StreamReader reader = new StreamReader("Data.json");
            string dataJson = reader.ReadToEnd();
            userTransactions = JsonConvert.DeserializeObject<List<TransactionModel>>(dataJson);
        }
    }
}
