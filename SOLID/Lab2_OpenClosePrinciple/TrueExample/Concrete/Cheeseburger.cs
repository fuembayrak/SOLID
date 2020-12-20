using SOLID.OpenClosePrinciple.TrueExample.Abstract;


namespace SOLID.OpenClosePrinciple.TrueExample.Concrete
{
    class Cheeseburger : TrueMenu
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 21.50;
        }
    }
}
