using SOLID.InterfaceSegrationPrinciple.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegrationPrinciple.BadExample.Concrete
{
    public class Chicken : IBird  //Chicken.cs sınıfımız IBird.cs sınıfından kalıtım aldığında, gereksiz "Fly()" yeteneğinide kazanarak bu ilkeye ters düşülmüştür.
    {  
        public string Fly()
        {
            return "Bütün tavuklar uçamaz.";
        }

        public string Walk()
        {
            return "Tavuklar yürüyebilir.";
        }
    }
}
