namespace WS.EstacionamentoHexagonal.Domain.Entities
{
    public class Permanencia(Veiculo veiculo, DateTime dataEntrada)
    {
        public Veiculo Veiculo { get; private set; } = veiculo;
        public DateTime DataEntrada { get; private set; } = dataEntrada;

        public DateTime DataSaida { get; private set; } = DateTime.MinValue;

        public void RegistrarSaida(DateTime dataSaida)
        {
            if (dataSaida < DataEntrada)
                throw new InvalidOperationException(
                    "Data de saida não pode ser menor que a de entrada"
                    );

            DataSaida = dataSaida;

        }

        public TimeSpan CalculaTempoPermanencia()
        {
            if (DataSaida == DateTime.MinValue)
                throw new InvalidOperationException(
                   "Calculo de tempo de permanencia não pode ser chamado sem data de saida"
                   );

            var tempoPermanencia = DataSaida - DataEntrada;

            return tempoPermanencia;
        }

        public Double CalculaValorPermanencia(double valorHora)
        {
            var permanencia = CalculaTempoPermanencia();
            return permanencia.TotalHours * valorHora;
        }
    }
}
