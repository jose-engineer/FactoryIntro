using FactoryDP_Intro.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryDP_Intro.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int EmployeeTypeID)
        {
            IEmployeeManager returnValue = null;

            if (EmployeeTypeID == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }

            if (EmployeeTypeID == 2)
            {
                returnValue = new ContractEmployeeManager();
            }

            return returnValue;
        }
    }
}