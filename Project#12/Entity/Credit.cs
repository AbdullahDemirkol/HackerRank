namespace Project_12.Entity
{
    public class Credit
    {
        private int id = 1;

        public Credit(double totalCreditMoney,int creditAllCount)
        {
            Id = id;
            CreditAllCount = creditAllCount;
            TotalCreditMoney = totalCreditMoney;
            RemainingCreditMoneyThisMonth = totalCreditMoney / creditAllCount;
            CreditCountRemaining = creditAllCount;
            RemainingTotalCreditMoney = totalCreditMoney;
            id++;
        }

        public int Id { get; set; }
        public int CreditAllCount { get; set; }
        public int CreditCountRemaining { get; set; }
        public double TotalCreditMoney { get; set; }
        public double RemainingTotalCreditMoney { get; set; }
        public double RemainingCreditMoneyThisMonth { get; set; }


    }
}