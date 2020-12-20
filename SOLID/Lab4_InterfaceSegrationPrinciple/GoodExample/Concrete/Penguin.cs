using SOLID.InterfaceSegrationPrinciple.GoodExample.Interfaces;
using System;


namespace SOLID.InterfaceSegrationPrinciple.GoodExample.Concrete
{
    public class Penguin : IWalkBird, ISwimBird
    {
        public string Swim()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
