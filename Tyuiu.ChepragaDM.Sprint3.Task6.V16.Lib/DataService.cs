using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChepragaDM.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (x%i==0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
