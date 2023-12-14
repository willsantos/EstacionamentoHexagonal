using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.EstacionamentoHexagonal.Domain.Entities;

namespace WS.EstacionamentoHexagonal.Application.Dtos
{
    public class RelatorioVeiculosEstacionados
    {
        public DateTime Referencia { get; set; }
        public int TotalVeiculos { get; set; }
        public List<Permanencia> RegistroPermanencias { get; set; } = [];
    }
}
