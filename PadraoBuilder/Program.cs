using PadraoBuilder.Builders;
using PadraoBuilder.Directors;
using PadraoBuilder.Products;

VeiculoBuilder vbuild = new VeiculoBuilder();
Diretor diretor = new Diretor(vbuild);

diretor.ConstruirCarroSedan();

Veiculo sedan = vbuild.GetVeiculo();

Console.WriteLine($"veiculo tipo{sedan.TipoVeiculo}\n" +
    $"veiculo bancos{sedan.Bancos}\n" +
    $"veiculo Motor{sedan.Motor}\n" +
    $"veiculo transmissão {sedan.Transmisao}\n\n\n\n");

diretor.ConstruirCaminhao();

Veiculo caminhao = vbuild.GetVeiculo();
Console.WriteLine($"veiculo tipo{caminhao.TipoVeiculo}\n" +
    $"veiculo bancos{caminhao.Bancos}\n" +
    $"veiculo Motor{caminhao.Motor}\n" +
    $"veiculo transmissão {caminhao.Transmisao}\n\n\n\n");

Console.ReadLine();
