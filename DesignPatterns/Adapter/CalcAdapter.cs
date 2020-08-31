namespace DesignPatterns.Adapter
{
    public class CalcAdapter
    {
        public int CalculateArea(Square square)
        {
            var calcRectangle = new CalcRectangle();
            var rectangle = new Rectangle { Width = square.Side, Height = square.Side };
            var area = calcRectangle.CalculateArea(rectangle);

            return area;
        }
    }
}