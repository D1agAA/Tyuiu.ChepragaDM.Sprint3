using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChepragaDM.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] Array;
            int len = (stopValue -  startValue + 1);
            Array = new double[len];
            double y;
            int count = 0;
            for (int i = startValue;i <= stopValue;i++)
            {
                y = Math.Round(((((2 * i) - 3) / (Math.Cos(i) + i)) + 5), 2);
                Array[count] = y;
                count++;
            }
            return Array;
        }
    }
}
