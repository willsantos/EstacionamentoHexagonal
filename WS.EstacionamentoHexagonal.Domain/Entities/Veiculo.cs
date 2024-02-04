using System.Text.RegularExpressions;

namespace WS.EstacionamentoHexagonal.Domain.Entities
{
    public partial class Veiculo
    {
        private static readonly Regex regexPlaca =
            RegexPlaca();

        [GeneratedRegex(@"^[A-Z]{3}-?[0-9]{4}$|^[A-Z]{3}[0-9][A-Z][0-9]{2}$", RegexOptions.Compiled)]
        private static partial Regex RegexPlaca();

        public string Placa { get; set; }

        public Veiculo(string placa)
        {
           

            if (string.IsNullOrEmpty(placa.Trim()))
                throw new ArgumentException("A placa não pode ser nula ou vazia", nameof(placa));

            if (!regexPlaca.IsMatch(placa.Trim()))
                throw new ArgumentException("A placa não segue o formato válido", nameof(placa));

            Placa = placa.Trim();
        }

    }
}


