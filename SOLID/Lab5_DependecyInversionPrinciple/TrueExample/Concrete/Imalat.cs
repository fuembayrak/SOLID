using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Lab5_DependecyInversionPrinciple.TrueExample
{
    public class Imalat
    {
        //High Level Class
        public void Olustur()
        {
            Kek kek = new Kek();
            kek.KekYap(true);
        }
    }
}
