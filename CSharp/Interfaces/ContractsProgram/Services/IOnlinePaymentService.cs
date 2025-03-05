using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsProgram.Services
{
    interface IOnlinePaymentService
    {
        public double MonthlySimpleInterest(double amount, int month);
        public double PaymentFee(double amount);
    }
}
