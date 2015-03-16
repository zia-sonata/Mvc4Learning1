using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Student.Interface;

namespace Sudent.BusinessRepository
{
   public  class FeesCalculator:IFeesCalculator
    {
        public int CalculateFees(int studentId)
        {
            return 1000;
            //throw new NotImplementedException();
        }
    }
}
