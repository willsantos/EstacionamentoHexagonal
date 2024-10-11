using NSubstitute;
using WS.EstacionamentoHexagonal.Application.Dtos;
using WS.EstacionamentoHexagonal.Application.Ports;
using WS.EstacionamentoHexagonal.Application.UseCases;
using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Tests.Application.UseCases;

[Trait("TestObterVeiculosEstacionadosUsecase",
    "Testa o UseCase ObterVeiculosEstacionados")]
public class TestObterVeiculosEstacionados
{
    [Fact(DisplayName = "Deve Retornar uma lista de veiculos estacionados")]
    public async Task TestDeveObterVeiculosEstacionados()
    {
        // Arrange
        var repoMongo = Substitute.For<IPermanenciaRepository>();
        var veiculosEstacionadosEsperados = new List<Permanencia>
        {
            new(new Veiculo("ABC-1234"), DateTime.Now),
            new(new Veiculo("XYZ-7890"), DateTime.Now)
        };
        var relatorioEsperado = new RelatorioVeiculosEstacionados
        {
            Referencia = DateTime.Today,
            RegistroPermanencias = veiculosEstacionadosEsperados,
            TotalVeiculos = veiculosEstacionadosEsperados.Count
        };
        repoMongo.Buscar().Returns(Task.FromResult(relatorioEsperado));
        var obterVeiculosEstacionados =
            new ObterVeiculosEstacionados(repoMongo);
        // Act
        var veiculosEstacionados = await obterVeiculosEstacionados.Executar();
        // Assert
        Assert.NotNull(veiculosEstacionados);
    }
}