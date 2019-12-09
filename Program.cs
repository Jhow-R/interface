using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Buscar em Esportes ou Times [E/T]? ");
            ConsoleKeyInfo escolha = Console.ReadKey();

            Console.Write("\n Digite criterio de busca: ");
            string criterio = Console.ReadLine();

            Dicionario buscar = new Dicionario(escolha, criterio);

            List<string> lista = buscar.Procurar();

            Console.WriteLine("Resultado: \n");

            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
