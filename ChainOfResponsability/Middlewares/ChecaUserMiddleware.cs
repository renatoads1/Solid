using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    class ChecaUserMiddleware : Middleware
    {
        private Server _server;

        public ChecaUserMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Checa(string login, string password)
        {
            if (!_server.TemEmail(login))
            {
                Console.WriteLine("Login Invalido");
                return false;
            }

            if (!_server.PasswordEValido(login, password)) {
                Console.WriteLine("Password é Invalido");
                return false;
            }

            return ChecaProximo(login,password);
        }
    }
}
