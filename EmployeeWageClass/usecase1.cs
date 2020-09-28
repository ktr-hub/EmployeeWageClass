using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageClass
{
    class usecase1
    {
        public Boolean IsPresent()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);
            if (attendance == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
