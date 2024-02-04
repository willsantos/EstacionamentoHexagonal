using WS.EstacionamentoHexagonal.Application.Dtos;

namespace WS.EstacionamentoHexagonal.Application.Ports;

public interface IPermanenciaRepository
{
    Task Adicionar(RegistroEntradaVeiculoDto registroEntradaVeiculoDto);
    Task <RelatorioVeiculosEstacionados>Buscar();
}