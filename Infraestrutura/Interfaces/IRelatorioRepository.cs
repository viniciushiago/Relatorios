using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces
{
    public interface IRelatorioRepository
    {
        Task<RelatorioResumoResponse> ObterResumoAsync(DateTime? inicio, DateTime? fim);
        Task<IEnumerable<RelatorioPorCategoriaResponse>> ObterPorCategoriaAsync(DateTime? inicio, DateTime? fim);
    }
}
