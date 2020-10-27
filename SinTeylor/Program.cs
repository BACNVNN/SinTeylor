using System;
// Задача №21
namespace SinTeylor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для того чтобы программа могла рассчитать sin(x), введите x (в градусах)");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine( "sin({0}) = {1}", a, Series(a) );

            Console.ReadLine(); // для того чтобы окно не закрывалось сразу после вывода результата
            
        }
        static double Series(double x) // Метод, задающий и вычисляющий ряд Тейлора для синуса
        {
            double Taylor = 0; // создание суммы ряда
            int k = 1;
            double j = 1;
            for (int i = 0; i <= 201; i++) // разложение sin(x) в ряд Тейлора {x - x^3 / 3! + x^5 / 5! + .... -x^201 / 201!}
            {
               if (i % 2 != 0)
                {
                    double TaylorI = k * Math.Pow(x*Math.PI/180, i); // числитель ощего члена ряда
                    Taylor += TaylorI / j;
                    j *= (i+1)*(i+2); // факториал в знаментале
                    k *= -1; // ряд знакочередующийся
                }
                Taylor = Math.Round(Taylor, 9); // округление ответа
            }
            return Taylor;

        }
       
    }
}
