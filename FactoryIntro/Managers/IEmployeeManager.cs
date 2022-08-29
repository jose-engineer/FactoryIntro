using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP_Intro.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();        

        decimal GetPay();        
    }
}
