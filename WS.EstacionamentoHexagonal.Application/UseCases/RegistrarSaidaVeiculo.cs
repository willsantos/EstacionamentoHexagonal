using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WS.EstacionamentoHexagonal.Application.Dtos;
using WS.EstacionamentoHexagonal.Application.Ports;

namespace WS.EstacionamentoHexagonal.Application.UseCases
{
    public class RegistrarSaidaVeiculo : IRegistrarSaidaVeiculo
    {
        // ...

        public Task<ResumoSaidaVeiculoDto> Executar(RegistroSaidaVeiculoDto registroSaida)
        {
            throw new NotImplementedException();
        }
    }
}
