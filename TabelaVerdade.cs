using System;
/* ETEC Antonio Furlan
TABELA VERDADE
version 1.0v
@outhor Nathalia L.C 15.03.22
*/
namespace TabelaVerdade
{
    class TabelaVerdade
    {
        static void Main(string[] args)
        {
            bool p1 = true;
            bool p2 = true;
            bool p3 = false;
            bool p4 = false;

            bool q1 = true;
            bool q2 = false;
            bool q3 = true;
            bool q4 = false;
            Console.WriteLine($"{p1},{p2},{p3},{p4},{q1},{q2},{q3},{q4}");
            if (p1 == true || q1 == true)
            {
             Console.WriteLine("Vou para festa com Paula e com Quezia, porque as duas vieram");
            }
            if (p2==true || q2 == true)
            {
             Console.WriteLine("Vou para a festa somente com a Paula, porque a Quesia não veio");
            }
        }
    }
}
