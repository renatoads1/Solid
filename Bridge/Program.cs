

using Bridge.Plataformas;
using Bridge.Transmissoes;

static void StartLive(IPlataforma plataforma) { 
    Live live = new Live(plataforma);
    live.Transmitir();
    live.Resultado();
}


    StartLive(new YouTube());
    StartLive(new FaceBook());
    StartLive(new Twith());
Console.ReadLine();
