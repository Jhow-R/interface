﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Dicionario
    {
        private string criterio;
        private ConsoleKeyInfo escolha;

        public Dicionario(ConsoleKeyInfo escolha, string criterio)
        {
            this.criterio = criterio;
            this.escolha = escolha;
        }

        public IEnumerable<string> Procurar()
        {
            IBuscador procurar;

            if (escolha.Key == ConsoleKey.E)
                procurar = new BuscadorEsportes();
            else
                procurar = new BuscadorTimes();

            return procurar.GetResultado(criterio);
        }
    }
}
