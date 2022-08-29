using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryDP_Intro.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 10;
        }
    }
}