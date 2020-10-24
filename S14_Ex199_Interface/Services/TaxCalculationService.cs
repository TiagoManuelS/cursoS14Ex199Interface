using System;
using System.Collections.Generic;
using System.Text;
using S14_Ex199_Interface.Services;

namespace S14_Ex199_Interface.Services
{
    class TaxCalculationService : ITaxService
    {
        public double Tax(double amount, int parcela)
        {
            
                return (amount * (1 + (0.01 * parcela))) * 1.02;
          

        }


    }
}
