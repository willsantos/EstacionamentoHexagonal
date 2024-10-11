using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.EstacionamentoHexagonal.Application.Dtos;
using WS.EstacionamentoHexagonal.Application.Ports;

namespace WS.EstacionamentoHexagonal.Application.UseCases
{
    internal class RegistrarEntradaVeiculo : IRegistrarEntradaVeiculo
    {
        public Task<ResumoEntradaVeiculoDto> Executar(RegistroEntradaVeiculoDto registroEntrada)
        {
            throw new NotImplementedException();
        }
    }
}
