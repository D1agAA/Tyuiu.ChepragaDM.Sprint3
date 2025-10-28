using Tyuiu.ChepragaDM.Sprint3.Task5.V13.Lib;


namespace Tyuiu.ChepragaDM.Sprint3.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
           


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");




            int x, i, i1, k, k1;
            x = 5;
            i = 1;
            i1 = 3;
            k = 1;
            k1 = 12;

            Console.WriteLine("Начало первой суммы:  " + k );
            Console.WriteLine("Конец первой суммы: " + k1);
            Console.WriteLine("Начало второй суммы:  " + i);
            Console.WriteLine("Конец второй суммы: " + i1);
            Console.WriteLine("Значение x:  " + x );
            







            double res = ds.GetSumSumSeries(x, i, k, i1, k1);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
