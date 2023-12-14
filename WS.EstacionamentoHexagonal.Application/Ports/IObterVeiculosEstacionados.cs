using WS.EstacionamentoHexagonal.Application.Dtos;

namespace WS.EstacionamentoHexagonal.Application.Ports
{
    public interface IObterVeiculosEstacionados
    {
        Task<RelatorioVeiculosEstacionados> Executar();

    }
}
