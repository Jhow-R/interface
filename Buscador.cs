using System.Collections.Generic;
using System.Linq;

namespace Interface
{
    class BuscadorEsportes : IBuscador
    {
        public IEnumerable<string> GetResultado(string criterio)
        {
            IEnumerable<string> esportes = new List<string> { "Futebol", "Voleibol", "Basquetebol", "Natação", "Rugby", "Handebol" };
            IEnumerable<string> resultado;

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
        public IEnumerable<string> GetResultado(string criterio)
        {
            IEnumerable<string> times = new List<string> { "Santos", "Palmeiras", "Vasco", "Coritiba", "Bahia" };
            IEnumerable<string> resultado;

            // Converte - se IEnumerable para List antes de atribuir a resultado
            resultado = times.Where(time => time.ToLower().Contains(criterio.ToLower()))
                             .Select(time => time).ToList();

            return resultado;
        }
    }
}
