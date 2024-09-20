using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> _user = new Dictionary<string, string>();

        private Middleware _middleware;
        public void SetMiddleware(Middleware middleware) { 
            
            _middleware = middleware;
        }
        public Boolean Logar(string login, string password) {

            if (_middleware.Checa(login,password))
            {
                Console.WriteLine("Login autorizado");
                return true;
            }
            return false;
        }
        public void Registrar(string login,string password) { 
            _user[login] = password;

        }

        public Boolean TemEmail(string login)
        {
            return _user.ContainsKey(login);
        }
        public Boolean PasswordEValido(string login, string password)
        {
            string value = "";
            _user.TryGetValue(login, out value);
            return password == value;
        }


    }
}
