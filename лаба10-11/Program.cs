namespace лаба10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите координаты первого вектора: ");
            Console.WriteLine("x: ");
            string input1 = Console.ReadLine();
            double x1 = Convert.ToDouble(input1);
            Console.WriteLine("y: ");
            string input2 = Console.ReadLine();
            double y1 = Convert.ToDouble(input2);

            Console.WriteLine("Введите координаты второго вектора: ");
            Console.WriteLine("x: ");
            string input3 = Console.ReadLine();
            double x2 = Convert.ToDouble(input3);
            Console.WriteLine("y: ");
            string input4 = Console.ReadLine();
            double y2 = Convert.ToDouble(input4);

            Console.WriteLine("Введите координаты третьего вектора: ");
            Console.WriteLine("x: ");
            string input5 = Console.ReadLine();
            double x3 = Convert.ToDouble(input5);
            Console.WriteLine("y: ");
            string input6 = Console.ReadLine();
            double y3 = Convert.ToDouble(input6);

            Console.WriteLine("Введите коэффициенты: ");
            Console.WriteLine("k1: ");
            string kf1 = Console.ReadLine();
            double k1 = Convert.ToDouble(kf1);

            Console.WriteLine("k2: ");
            string kf2 = Console.ReadLine();
            double k2 = Convert.ToDouble(kf2);

            Console.WriteLine("k3: ");
            string kf3 = Console.ReadLine();
            double k3 = Convert.ToDouble(kf3);

            Console.WriteLine("Теперь найдем r.....");

            double xr = (k1 * x1) + (k2 * x2) + (k3 * x3);

            double yr = (k1 * y1) + (k2 * y2) + (k3 * y3);

            Console.WriteLine($"Координата Х: {xr}");

            Console.WriteLine($"Координата Y: {yr}");

            Console.WriteLine($"r = ({xr};{yr})");

            Console.WriteLine("Ищем длину......");

            double lenx = Math.Pow(xr, 2);
            double leny = Math.Pow(yr, 2);
            double lenr = Math.Sqrt(lenx + leny);

            Console.WriteLine($"Длина r равна {lenr}");

            Console.WriteLine("Координаты вектора Q: ");

            Console.WriteLine("q1 = ");
            string inputq1 = Console.ReadLine();
            double q1 = Convert.ToDouble(inputq1);

            Console.WriteLine("q2 = ");
            string inputq2 = Console.ReadLine();
            double q2 = Convert.ToDouble(inputq2);

            Console.WriteLine("q3 = ");
            string inputq3 = Console.ReadLine();
            double q3 = Convert.ToDouble(inputq3);

            Console.WriteLine("Координаты вектора K1: ");

            Console.WriteLine("a1 = ");
            string inputa1 = Console.ReadLine();
            double a1 = Convert.ToDouble(inputa1);

            Console.WriteLine("a2 = ");
            string inputa2 = Console.ReadLine();
            double a2 = Convert.ToDouble(inputa2);

            Console.WriteLine("a3 = ");
            string inputa3 = Console.ReadLine();
            double a3 = Convert.ToDouble(inputa3);

            Console.WriteLine("Координаты вектора K2: ");

            Console.WriteLine("b1 = ");
            string inputb1 = Console.ReadLine();
            double b1 = Convert.ToDouble(inputb1);

            Console.WriteLine("b2 = ");
            string inputb2 = Console.ReadLine();
            double b2 = Convert.ToDouble(inputb2);

            Console.WriteLine("b3 = ");
            string inputb3 = Console.ReadLine();
            double b3 = Convert.ToDouble(inputb3);

            Console.WriteLine("Вычислим s1.....");

            double s1 = ((q1 * a1) + (q2 * a2) + (q3 * a3)) / Math.Sqrt(3);

            Console.WriteLine($"s1 = {s1}");

            Console.WriteLine("Вычислим s2.....");

            double s2 = ((q1 * b1) + (q2 * b2) + (q3 * b3)) / Math.Sqrt(3);

            Console.WriteLine($"s2 = {s2}");

            s1 = Math.Exp(s1);
            s2 = Math.Exp(s2);

            double exp = s1 + s2;

            double result1 = s1 / exp;
            double result2 = s2 / exp;

            Console.WriteLine($"Преобразованные s1 и s2 соответственно равны {result1} и {result2}");*/

            Console.WriteLine("Введите Tin: ");
            string input1 = Console.ReadLine();
            double tin = Convert.ToDouble(input1);

            Console.WriteLine("Введите Tout: ");
            string input2 = Console.ReadLine();
            double tout = Convert.ToDouble(input2);

            Console.WriteLine("Введите N: ");
            string input3 = Console.ReadLine();
            double n = Convert.ToDouble(input3);

            Console.WriteLine("Введите Cin: ");
            string input4 = Console.ReadLine();
            double cin = Convert.ToDouble(input4);

            Console.WriteLine("Введите Cout: ");
            string input5 = Console.ReadLine();
            double cout = Convert.ToDouble(input5);

            Console.WriteLine("все входящие за день токены:");
            double all_in_tokens = tin * n;
            Console.WriteLine(all_in_tokens);

            Console.WriteLine("Стоимость входящих токенов:");
            double in_token = (all_in_tokens / 1000000) * cin;
            Console.WriteLine(in_token);

            Console.WriteLine("все выходящие за день токены:");
            double all_out_tokens = tout * n;
            Console.WriteLine(all_out_tokens);

            Console.WriteLine("Стоимость выходящих токенов:");
            double out_token = (all_out_tokens / 1000000) * cout;
            Console.WriteLine(out_token);

            double result = in_token + out_token;

            Console.WriteLine($"Общая стоимость равна {result}");

        }
    }
}
