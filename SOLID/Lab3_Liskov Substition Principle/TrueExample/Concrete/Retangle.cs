using SOLID.Liskov_Substition_Principle.TrueExample.Abstract;


namespace SOLID.Liskov_Substition_Principle.TrueExample.Concrete
{
    public class Retangle : Shape
    {
        public int Width { get; set; }

        public double RetangleArea()
        {
            return Width * Edge;
        }
    }
}
