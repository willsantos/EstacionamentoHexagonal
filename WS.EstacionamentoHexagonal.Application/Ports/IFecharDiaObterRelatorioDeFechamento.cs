using WS.EstacionamentoHexagonal.Application.Dtos;

namespace WS.EstacionamentoHexagonal.Application.Ports
{
    public interface IFecharDiaObterRelatorioDeFechamento
    {
        Task<RelatorioFechamentoDiaDto> Executar(RegistroSaidaVeiculoDto registroSaida);
    }
}
