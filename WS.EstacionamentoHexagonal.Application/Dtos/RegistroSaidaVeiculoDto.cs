namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class RegistroSaidaVeiculoDto
    {
        public required string Placa { get; set; }
        public DateTime DataSaida { get; set; }
    }
}
