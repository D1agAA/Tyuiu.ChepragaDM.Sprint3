using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChepragaDM.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double i = startValue ;
            double res = 0;
            while (i <= stopValue)
            {
                
                res += Math.Pow(1/i, 2);
                i++;
            }
            return Math.Round(res, 3);
        }
    }
}
