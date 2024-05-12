using System.ComponentModel.Design;

namespace W_2_l_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę");

            a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine(a + " to liczba dodatnia");
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine(a + " to liczba zero");
                }
                else
                {
                    Console.WriteLine(a + " to liczba ujemna");
                };
            }
        }
    }

}