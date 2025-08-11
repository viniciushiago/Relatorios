using Aplicacao.Interfaces;
using Dominio.DTOs;
using Infraestrutura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Services
{
    public class RelatorioService : IRelatorioService
    {
        private readonly IRelatorioRepository _repository;

        public RelatorioService(IRelatorioRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<RelatorioPorCategoriaResponse>> ObterPorCategoriaAsync(DateTime? inicio, DateTime? fim)
        {
            return await _repository.ObterPorCategoriaAsync(inicio, fim);
        }

        public async Task<RelatorioResumoResponse> ObterResumoAsync(DateTime? inicio, DateTime? fim)
        {
            return await _repository.ObterResumoAsync(inicio, fim);
        }
    }
}
