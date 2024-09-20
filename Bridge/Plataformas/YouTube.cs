using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataformas
{
    class YouTube : IPlataforma
    {
        public YouTube()
        {
            ConfigureLive();
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube Autorizada.....");

        }

        public void ConfigureLive()
        {
            AuthToken();
            Console.WriteLine("Youtube Configurando.....");
        }
    }
}
