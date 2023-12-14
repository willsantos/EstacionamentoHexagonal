
using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class ResumoEntradaVeiculoDto
    {
        public required Veiculo Veiculo { get; set; }
        public DateTime DataEntrada { get; set; }

    }
}
