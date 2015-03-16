using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student.Interface
{
    public interface IFeesCalculator
    {
        int CalculateFees(int studentId);
    }
}
