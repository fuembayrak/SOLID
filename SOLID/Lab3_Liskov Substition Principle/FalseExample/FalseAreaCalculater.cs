

namespace SOLID.Liskov_Substition_Principle
{
    class FalseAreaCalculater
    {
        public static double CalculateArea(FalseRetangle badRetangle)
        {
            return badRetangle.Height * badRetangle.Width;
        }

        public static double CalculateArea(FalseSquare badSquare)
        {
            //ters düştük neden yanlış atadan gereksiz özellikleir kalıtım aldığından karenin uzunluğu olmaz.
            return badSquare.Height * badSquare.Width;
        }
    }
}
