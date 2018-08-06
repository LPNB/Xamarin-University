using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    public class Bank
    {
        // TODO: Create GetAccountInfo method with the following specs:
        // Parameters:
        //   - accountNumber (string)
        //   - balance (double) ***
        //   - lastDeposit (DateTime) ***
        // Return type:
        //   - bool

        //Note: Parameters with *** should be defined as out parameters

        public bool GetAccountInfo(string accountNumber, out double balance, out DateTime lastDeposit)
        {
            balance = 254543.22;
            lastDeposit = new DateTime(2014, 11, 22, 14, 35, 20);

            bool isActive = true;
            return isActive;
        }
    }
}
