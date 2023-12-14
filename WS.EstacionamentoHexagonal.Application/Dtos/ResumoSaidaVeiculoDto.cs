using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class ResumoSaidaVeiculoDto
    {
        public required Veiculo Veiculo { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public TimeSpan TempoPermanencia { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
