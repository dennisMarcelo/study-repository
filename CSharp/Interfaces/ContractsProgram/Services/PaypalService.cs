namespace ContractsProgram.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double MonthlySimpleInterest(double amount, int month)
        {
            return amount + amount * MonthlyInterest * month;
        }

        public double PaymentFee(double amount)
        {
            return amount + amount * FeePercentage;
        }
    }
}
