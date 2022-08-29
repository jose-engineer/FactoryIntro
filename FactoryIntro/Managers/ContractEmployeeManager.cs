using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryDP_Intro.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 3;
        }

        public decimal GetPay()
        {
            return 6;
        }
    }
}