using WS.EstacionamentoHexagonal.Application.Dtos;

namespace WS.EstacionamentoHexagonal.Application.Ports
{
    public interface IRegistrarSaidaVeiculo
    {
        Task<ResumoSaidaVeiculoDto> Executar(RegistroSaidaVeiculoDto registroSaida);
    }
}
