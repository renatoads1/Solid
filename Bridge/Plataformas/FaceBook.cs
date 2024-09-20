using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataformas
{
    class FaceBook : IPlataforma
    {
        public FaceBook() {
            ConfigureLive();
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook Autorizada.....");

        }

        public void ConfigureLive()
        {
            AuthToken();
            Console.WriteLine("Facebook Configurando.....");
        }
    }
}
