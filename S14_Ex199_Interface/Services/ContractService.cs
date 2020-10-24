using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using Microsoft.VisualBasic;
using S14_Ex199_Interface.Entities;

namespace S14_Ex199_Interface.Services
{
    class ContractService
    {
        public int Parcelas { get; set; }

        private ITaxService _taxService;

        public ContractService(int parcelas, ITaxService taxService)
        {
            Parcelas = parcelas;
            _taxService = taxService;
        }

        public void ProcessInstallment(Entities.Contract contract)
        {
            double valuePerMonth = contract.TotalValue / Parcelas;
            

            for(int i = 1; i <= Parcelas; i++)
            {
                DateTime dueDate = contract.InitialDate.AddMonths(i);
                double valorInstallment = _taxService.Tax(valuePerMonth, i);

                contract.list.Add(new Installment(dueDate, valorInstallment));
                    

            }


        }

    }
}
