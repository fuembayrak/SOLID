using SOLID.InterfaceSegrationPrinciple.GoodExample.Interfaces;
using System;

namespace SOLID.InterfaceSegrationPrinciple.GoodExample.Concrete
{
    public class Chicken : IWalkBird
    {
        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
