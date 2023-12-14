using WS.EstacionamentoHexagonal.Application.Dtos;

namespace WS.EstacionamentoHexagonal.Application.Ports
{
    public interface IRegistrarEntradaVeiculo
    {
        Task<ResumoEntradaVeiculoDto> Executar(RegistroEntradaVeiculoDto registroEntrada);
    }
}
