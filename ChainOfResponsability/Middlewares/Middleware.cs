using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    abstract class Middleware
    {
        private Middleware _next;
        public Middleware LinkEste(Middleware next) { 
            
            _next = next;
            return _next;
        }

        public abstract Boolean Checa(string login, string password);

        protected Boolean ChecaProximo(string login, string password) {

            if (_next == null)
            {
                return true;//terminou
            }
            return _next.Checa(login, password);
        }

    }
}
