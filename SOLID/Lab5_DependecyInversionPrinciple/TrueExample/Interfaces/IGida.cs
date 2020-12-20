using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Lab5_DependecyInversionPrinciple.TrueExample
{
    public interface IGida
    {
        void Yap(bool Kakao);
    }

    public class Imalat
    {
        //High Level Class
        IGida gida;
        public Imalat()
        {
            gida = new Kek();
        }
        public void Olustur()
        {
            gida.Yap(true);
        }
    }

    public class Kek : IGida
    {
        //Low Level Method
        public void Yap(bool Kakao)
        {
            //Process
        }
    }
}
