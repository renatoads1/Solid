

using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

class Program { 
    private static Server _server;
    static void iniciar() { 
        _server = new Server();
        _server.Registrar("renatoads1@gmail.com", "auheuhaeuah");
        Middleware middleware = new ChecaUserMiddleware(_server);
        middleware.LinkEste(new ChechaPermissaoMiddleware());
        _server.SetMiddleware(middleware);
    }

    public static void Main(String[] args) { 
        iniciar();

        Boolean feito = false;

        do {
            Console.WriteLine("Digite seu Email");
            var login = Console.ReadLine();
            Console.WriteLine("Digite seu Password");
            var password = Console.ReadLine();

            _server.Logar(login, password);

        } while (!feito);
        Console.ReadKey();
    }
}