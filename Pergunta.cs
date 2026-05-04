using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp_BaseDados
{
    public class Pergunta
    {
        public string Enunciado { get; set; } // parametro
        public List<string> Alternativas { get; set; } // get= pega o valor ; set= definir o valor ou seja, consegue ler e modificar
        public string AltCorreta { get; set; }
    }
}
