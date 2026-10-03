namespace лаба12_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input1 = Console.ReadLine();
            double temp = Convert.ToDouble(input1);
            string cold = temp < 0 ? "Мороз" : "Нет мороза";
            Console.WriteLine(cold);

            Console.Write("Введите a: ");
            string input1 = Console.ReadLine();
            double a = Convert.ToDouble(input1);

            Console.Write("Введите b: ");
            string input2 = Console.ReadLine();
            double b = Convert.ToDouble(input2);

            Console.Write("Введите a: ");
            string input3 = Console.ReadLine();
            double c = Convert.ToDouble(input3);

            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Дискриминант равен {d}");

            if (d > 0)
            {
                Console.WriteLine("Квадратное уравнение имеет два различных действительных корня");
            }

            else
            {
                Console.WriteLine("Квадратное уравнение НЕ имеет два различных действительных корня");
            }

            string input1 = Console.ReadLine();
            int month = Convert.ToInt32(input1);

            switch (month) { 
                case 1:
                case 2: 
                case 3:
                    Console.WriteLine("Это квартал 1");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Это квартал 2");
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Это квартал 3");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Это квартал 4");
                    break;
            }*/

            Console.WriteLine("Введите номер месяца:");

            string input1 = Console.ReadLine();
            int month = Convert.ToInt32(input1);

            string season = month switch
            {
                12 or 1 or 2 => "зима",
                3 or 4 or 5 => "весна",
                6 or 7 or 8 => "лето",
                9 or 10 or 11 => "осень",

            };

            Console.WriteLine($"Сейчас {season}");
        }
    }
}
