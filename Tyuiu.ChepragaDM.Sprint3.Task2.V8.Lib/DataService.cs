using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChepragaDM.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            int i = startValue;
            do
            {
                res = res * (1.0 / ((Math.Cos(5) + 1) * (Math.Cos(5) + 1)));
                i++;

            } while (i <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
