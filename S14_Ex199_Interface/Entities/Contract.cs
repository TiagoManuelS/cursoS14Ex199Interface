using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using S14_Ex199_Interface.Entities;

namespace S14_Ex199_Interface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime InitialDate { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> list = new List<Installment>();

        public Contract(int number, DateTime initialDate, double totalValue)
        {
            Number = number;
            InitialDate = initialDate;
            TotalValue = totalValue;
        }



    }
}
