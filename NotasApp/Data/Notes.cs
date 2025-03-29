using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AppNotes.Data
{
    public class Nota
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        public Nota(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }
    }
}