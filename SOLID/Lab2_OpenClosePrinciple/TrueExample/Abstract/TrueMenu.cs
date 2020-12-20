using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple.TrueExample.Abstract
{

    public abstract class TrueMenu
    {
        public abstract double GetTotalPrice(double amount);
    }
}