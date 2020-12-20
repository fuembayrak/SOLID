

using SOLID.Liskov_Substition_Principle.TrueExample.Abstract;

namespace SOLID.Liskov_Substition_Principle.TrueExample.Concrete
{
    public class Square : Shape
    {
        public double SquareArea()
        {
            return Edge * Edge;
        }
    }
}
