using SOLID.InterfaceSegrationPrinciple.BadExample.Interfaces;


namespace SOLID.InterfaceSegrationPrinciple.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public string Fly()
        {
            return "Bütün şahinler uçabilir.";
        }

        public string Walk()
        {
            return "Bütün şahinler yürüyebilir.";
        }
    }
}
