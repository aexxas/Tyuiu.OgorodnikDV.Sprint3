using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.OgorodnikDV.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double y = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    y *= (x / (Math.Sin(x))) + 0.5;
                }
            }
            return Math.Round(y, 3);
        }
    }
}
