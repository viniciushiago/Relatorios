using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IRelatorioService
    {
        Task<RelatorioResumoResponse> ObterResumoAsync(DateTime? inicio, DateTime? fim);
        Task<IEnumerable<RelatorioPorCategoriaResponse>> ObterPorCategoriaAsync(DateTime? inicio, DateTime? fim);
    }
}
