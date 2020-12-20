using SOLID.OpenClosePrinciple.TrueExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosePrinciple.TrueExample.Concrete
{
    public class DoubleBurger : TrueMenu
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 27.75;
        }
    }
}
