using SOLID.InterfaceSegrationPrinciple.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegrationPrinciple.GoodExample.Concrete
{
    public class Hawk : IWalkBird, IFlightBird
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
