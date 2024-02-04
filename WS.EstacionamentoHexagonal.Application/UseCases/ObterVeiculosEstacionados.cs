using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.EstacionamentoHexagonal.Application.Dtos;
using WS.EstacionamentoHexagonal.Application.Ports;

namespace WS.EstacionamentoHexagonal.Application.UseCases
{
    public class ObterVeiculosEstacionados : IObterVeiculosEstacionados
    {
        private readonly IPermanenciaRepository _repository;

        public ObterVeiculosEstacionados(IPermanenciaRepository repository)
        {
            _repository = repository;
        }


        public Task<RelatorioVeiculosEstacionados> Executar()
        {
           return _repository.Buscar();
        }
    }
}
