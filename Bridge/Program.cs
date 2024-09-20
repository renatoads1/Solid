

using Bridge.Plataformas;
using Bridge.Transmissoes;

static void StartLive(IPlataforma plataforma) { 
    Live live = new Live(plataforma);
    live.Transmitir();
    live.Resultado();
}
static void StartLiveAvancada(IPlataforma plataforma)
{
    LiveAvancada live = new LiveAvancada(plataforma);
    live.Transmitir();
    live.Resultado();
    live.Legendas();
    live.Comentarios();
}

    StartLiveAvancada(new YouTube());
    StartLive(new FaceBook());
    StartLive(new Twith());
Console.ReadLine();
