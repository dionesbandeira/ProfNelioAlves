using System;
using ProfNelioAlves.Entities;


namespace ProfNelioAlves.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }



        public void ProcessContract(Contract contract, int months) 
        {
            double basicQuota = contract.ValueTotalConstract / months;

            for (int i=1; i <= months; i++ )
            {
                DateTime data = contract.DateContract.AddDays(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota * _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallent(new Installment(data, fullQuota));

            }        
        }
    }
}
