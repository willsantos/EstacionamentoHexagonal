
using System.Globalization;
using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Tests.Core
{
    public class TestPermanencia
    {

        [Fact]
        public void Teste_AdicionarDataSaida_ComSucesso()
        {
            var veiculo = new Veiculo("EHX-1770");
            var dataEntrada = DateTime.ParseExact("14-02-2023T14:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var dataSaida = DateTime.ParseExact("14-02-2023T15:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            
            var permanencia = new Permanencia(veiculo, dataEntrada);

            permanencia.RegistrarSaida(dataSaida);

            Assert.Equal(dataSaida, permanencia.DataSaida);
        }

        [Fact]
        public void Teste_QuandoDataSaidaMenorQueDataEntrada_DeveLancarInvalidOperationException()
        {
            var veiculo = new Veiculo("EHX-1770");
            var dataEntrada = DateTime.ParseExact("14-02-2023T14:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var dataSaida = DateTime.ParseExact("14-02-2023T11:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);

            var permanencia = new Permanencia(veiculo, dataEntrada);

            void registrarSaida() => permanencia.RegistrarSaida(dataSaida);

            var excecao = Assert.Throws<InvalidOperationException>(registrarSaida);
            Assert.Equal("Data de saida não pode ser menor que a de entrada", excecao.Message);
        }

        [Fact]
        public void Teste_CalculaTempoPermanencia_ComSucesso()
        {
            var veiculo = new Veiculo("EHX-1770");
            var dataEntrada = DateTime.ParseExact("14-02-2023T14:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var dataSaida = DateTime.ParseExact("14-02-2023T15:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var tempoEsperado = new TimeSpan(1, 0, 0);

            var permanencia = new Permanencia(veiculo, dataEntrada);

            permanencia.RegistrarSaida(dataSaida);

            var tempoPermanencia = permanencia.CalculaTempoPermanencia();

            Assert.Equal<TimeSpan>(tempoEsperado, tempoPermanencia);
        }

        [Fact]
        public void Teste_QuandoCalculaTempoPermanenciaSemDataSaida_DeveLancarInvalidOperationException()
        {
            var veiculo = new Veiculo("EHX-1770");
            var dataEntrada = DateTime.ParseExact("14-02-2023T14:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var dataSaida = DateTime.ParseExact("14-02-2023T15:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var tempoEsperado = new TimeSpan(1, 0, 0);

            var permanencia = new Permanencia(veiculo, dataEntrada);

            void tempoPermanencia() => permanencia.CalculaTempoPermanencia();

            var excecao = Assert.Throws<InvalidOperationException>(tempoPermanencia);
            Assert.Equal("Calculo de tempo de permanencia não pode ser chamado sem data de saida", excecao.Message);
        }


        [Fact]
        public void Teste_CalculaValorPermanencia_ComSucesso()
        {
            var veiculo = new Veiculo("EHX-1770");
            var dataEntrada = DateTime.ParseExact("14-02-2023T14:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var dataSaida = DateTime.ParseExact("14-02-2023T15:30", "dd-MM-yyyyTHH:mm", CultureInfo.InvariantCulture);
            var  valorHora = 10.00;
            var permanencia = new Permanencia(veiculo, dataEntrada);

            permanencia.RegistrarSaida(dataSaida);

            var valorTotal = permanencia.CalculaValorPermanencia(valorHora);

            Assert.Equal(valorHora, valorTotal);

        }

      
    }
}