using System;

namespace SinTeylor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для того чтобы программа могла рассчитать sin(x), введите x (в градусах)");
            double a = Convert.ToDouble(Console.ReadLine());
            Series(a);
           
            Console.ReadLine(); // для того чтобы окно не закрывалось сразу после вывода результата
            
        }
        static void Series(double x) // Метод, задающий ряд Тейлора для синуса
        {
            double s = 0; // создание суммы ряда
            int k = 1;
            double j = 1;
            for (int i = 0; i <= 250; i++) // разложение sin(x) в ряд Тейлора {x - x^3 / 3! + x^5 / 5! + .... -x^249 / 249!}
            {
               if (i % 2 != 0)
                {
                    double a = k * Math.Pow(x*Math.PI/180, i); // числитель ощего члена ряда
                    s += a / j;
                    j *= (i+1)*(i+2); // факториал в знаментале
                    k *= -1; // ряд знакочередующийся
                }
                s = Math.Round(s, 7); // округление ответа до 9ого знака после запятой
            }
            Console.WriteLine("sin({0}) = {1}", x, s);

        }
        static void Err(double abserr, double err, double value)
        {
            double err = Math.Sin(x*Math.PI/180) - 
        }
    }
}
