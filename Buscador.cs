using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Buscador : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            List<string> esportes = new List<string> { "Futebol", "Voleibol", "Basquetebol", "Natação", "Rugby", "Handebol" };
            List<string> resultado = new List<string>();

            // Converte - se IEnumerable para List antes de atribuir a resultado
            // Declarativo ou query syntax
            resultado = (from esp in esportes where esp.Contains(criterio) select esp).ToList();
            // Imperativo ou method syntax
            resultado = esportes.Where(esp => esp.ToLower().Contains(criterio.ToLower()))
                                .Select(esp => esp).ToList();

            return resultado;
        }
    }

    class BuscadorTimes : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            List<string> times = new List<string> { "Santos", "Palmeiras", "Vasco", "Coritiba", "Bahia" };
            List<string> resultado = new List<string>();

            resultado = times.Where(time => time.ToLower().Contains(criterio.ToLower()))
                             .Select(time => time).ToList();

            return resultado;
        }
    }
}
