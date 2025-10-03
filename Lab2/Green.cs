using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double sm = 0;
            for (double i = 0; i <= n; i = i + 2)
            {
                sm += (double)i / (i + 1);
            }
            answer = sm;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double sum = 1;
            double zn = 1;
            for (int i = 1; i <= n; i++)
            {
                zn *= x;
                sum += (1 / zn);
            }
            answer = sum;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;       // теперь fact = i!
                answer += fact;  // добавляем
            }
            return answer;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double E = 1e-4;
            double sm = 0;
            double arg = 1;
            for (int n = 1; n < 1000; n++)
            {
                arg *= x;
                Console.WriteLine(arg);
                double sin = Math.Sin(n * arg);

                sm += sin;
                if (Math.Abs(sin) < E)
                {
                    break;
                }
            }
            answer = sm;
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double E = 1e-4;
            for (double i = -10; i < 1000; i++)
            {
                double rasnost = Math.Abs((1 / Math.Pow(x, i)) - (1 / Math.Pow(x, i - 1)));
                if (rasnost < E)
                {
                    answer = (int)i;
                    break;
                }
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            return answer;
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double D = 1e-10; // диаметр атома по умолчанию (например, водород)

            while (L > D)
            {
                L /= 2.0;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-12; x += h)
            //1e-12 нужно для минимальной погрешности
            //то есть комп о,1 хранит как 0,10001 и тогда будет ошибка потому что результат не точный
            {
                int i = 0;
                double temp;
                double sum = 0;
                do
                {
                    temp = Math.Pow(-1, i) * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
                    sum += temp;
                    i++;
                } while (Math.Abs(temp) > E);

                SS += sum;
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}
