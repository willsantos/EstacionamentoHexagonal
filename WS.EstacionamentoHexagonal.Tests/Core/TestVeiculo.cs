using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Tests.Core
{
    public class TestVeiculo
    {


        [Theory]
        [InlineData("JTR-5678")]
        [InlineData("MNB-4321")]
        [InlineData("QWE9R34")]
        [InlineData("ZXC4T12")]
        public void Teste_QuandoPlacaValida_DeveRetornarPlaca(string placa)
        {
            Veiculo veiculo = new(placa: placa);

            Assert.Equal(expected: placa, veiculo.Placa);

        }

        [Theory]
        [InlineData("xxxx")]
        [InlineData("ABC1C3412")]
        [InlineData("EHX-17701")]
        public void Teste_QuandoPlacaInvalida_DeveLancarInvalidArgumentException(string placa)
        {
            var excecao = Assert.Throws<ArgumentException>(NovoVeiculo);
            Assert.Equal("A placa não segue o formato válido (Parameter 'placa')", excecao.Message);
            return;

            void NovoVeiculo() => _ = new Veiculo(placa);
        }

        [Theory]      
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("       ")]
        public void Teste_QuandoPlacaVazia_DeveLancarInvalidArgumentException(string placa)
        {
            var excecao = Assert.Throws<ArgumentException>(NovoVeiculo);
            Assert.Equal("A placa não pode ser nula ou vazia (Parameter 'placa')", excecao.Message);
            return;

            void NovoVeiculo() => _ = new Veiculo(placa);
        }

    }
}
