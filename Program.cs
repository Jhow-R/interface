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
            ConsoleKeyInfo escolha;
            string criterio;

            do
            {
                Console.Write("Buscar em Esportes ou Times [E/T]? ");
                escolha = Console.ReadKey();
                Console.WriteLine();

            } while ((escolha.Key != ConsoleKey.E) && (escolha.Key != ConsoleKey.T));

            Console.Write("Digite criterio de busca: ");
            criterio = Console.ReadLine();

            Dicionario buscar = new Dicionario(escolha, criterio);

            IEnumerable<string> lista = buscar.Procurar();

            if (lista.Count() != 0)
            {
                Console.WriteLine("\nResultado: ");
                foreach (var item in lista)
                    Console.WriteLine(item.ToString());
            }
            else
                Console.WriteLine("Não há ocorrências com o critério escolhido.");


            Console.ReadLine();
        }
    }
}
