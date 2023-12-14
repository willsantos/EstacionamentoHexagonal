namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class RegistroEntradaVeiculoDto
    {
        public required string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
