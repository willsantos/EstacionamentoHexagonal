using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class RelatorioFechamentoDiaDto
    {
        public  decimal TotalVendas { get; set; }
        public DateTime Referencia { get; set; }
        public int TotalVeiculos { get; set; }
        public List<Permanencia> RegistroPermanencias { get; set; } = [];

    }
}
