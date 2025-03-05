using ContractsProgram.Entities;

namespace ContractsProgram.Services
{
    class ContractsService
    {

        private IOnlinePaymentService _OnlinePaymentService;

        public ContractsService(IOnlinePaymentService onlinePaymentService)
        {
            _OnlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double monthlySimpleInterest = _OnlinePaymentService.MonthlySimpleInterest(basicQuota, i);
                double paymentFee = _OnlinePaymentService.PaymentFee(monthlySimpleInterest);
                contract.AddInstallment(new Installment(date, paymentFee));
            }
        }
    }
}
