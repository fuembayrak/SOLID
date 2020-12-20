
using SOLID.OpenClosePrinciple.TrueExample.Abstract;

namespace SOLID.OpenClosePrinciple.TrueExample.Concrete
{
    public class Hamburger : TrueMenu
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 18.50;
        }
    }
}
