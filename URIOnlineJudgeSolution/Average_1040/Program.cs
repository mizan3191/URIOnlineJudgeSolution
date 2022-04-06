using System;

namespace Average_1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var convert = input.Split(' ');

            var N1 = Convert.ToDouble(convert[0]);
            var N2 = Convert.ToDouble(convert[1]);
            var N3 = Convert.ToDouble(convert[2]);
            var N4 = Convert.ToDouble(convert[3]);

            N1 = N1 * 2;
            N2 = N2 * 3;
            N3 = N3 * 4;
            N4 = N4 * 1;

            var sum = (N1 + N2 + N3 + N4);
            var avarage = sum / 10;

            Console.WriteLine("Media: {0:0.0}", avarage);

            if (avarage >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avarage >= 5.0 && avarage <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                var exam = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {exam}");

                var recalculate = (avarage + exam) / 2;

                if (recalculate >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: {0:0.0}", recalculate);

            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
