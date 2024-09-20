using Bridge.Plataformas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    class LiveAvancada : Live
    {
        public LiveAvancada(IPlataforma plataforma) : base(plataforma)
        {

        }

        public void Legendas() {
            Console.WriteLine("Legendas Ativas");
        }

        public void Comentarios() {
            Console.WriteLine( "Comentarios Ativados ");
        }
    }
}
