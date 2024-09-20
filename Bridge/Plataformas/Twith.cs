using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataformas
{
     class Twith : IPlataforma
    {
        public Twith()
        {
            ConfigureLive();
        }
        public void AuthToken()
        {
            Console.WriteLine("Twith Autorizada.....");

        }

        public void ConfigureLive()
        {
            AuthToken();
            Console.WriteLine("Twith Configurando.....");
        }
    }
}
