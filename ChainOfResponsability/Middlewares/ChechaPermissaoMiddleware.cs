using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    class ChechaPermissaoMiddleware : Middleware
    {

        public override bool Checa(string login, string password)
        {
            if (login.Equals("renatoads1@gmail.com")) {
                Console.WriteLine("Bem vindo Administrador");
                return true;
            }

            Console.WriteLine("Seja Bem vindo");
            return ChecaProximo(login, password);
        }
    }
}
