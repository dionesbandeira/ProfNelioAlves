using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;     //Taxa de porcentagem
        private const double MonthlyInterest = 0.01;  //Juros mensais


        public double Interest(double amount, int monthrs)
        {
            return amount * MonthlyInterest * monthrs;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

    }
}
