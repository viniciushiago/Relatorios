using Dominio.DTOs;
using Dominio.Entities;
using Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositories
{
    public class RelatoriosRepository : IRelatorioRepository
    {
        private readonly AppDbContext _context;

        public RelatoriosRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RelatorioPorCategoriaResponse>> ObterPorCategoriaAsync(DateTime? inicio, DateTime? fim)
        {
            var query = _context.Transacoes.Include(x => x.Categoria).AsQueryable();

            if (inicio.HasValue)
            {
                query = query.Where(x => x.Data >= inicio.Value);
            }

            if (fim.HasValue){
                query = query.Where(x => x.Data <= fim.Value);
            }

            var grupo = await query
                .GroupBy(x => new { x.CategoriaId, x.Categoria.Nome })
                .Select(g => new RelatorioPorCategoriaResponse
                {
                    CategoriaId = g.Key.CategoriaId,
                    CategoriaNome = g.Key.Nome,
                    TotalReceitas = g.Where(x => x.Categoria.Tipo == TipoCategoria.Receita)
                        .Sum(x => (decimal?)x.Valor) ?? 0,
                    TotalDespesas = g.Where(x => x.Categoria.Tipo == TipoCategoria.Despesa)
                        .Sum(x => (decimal?)x.Valor) ?? 0
                }).ToListAsync();

            return grupo;
        }

        public async Task<RelatorioResumoResponse> ObterResumoAsync(DateTime? inicio, DateTime? fim)
        {
            var query = _context.Transacoes.Include(x => x.Categoria).AsQueryable();

            if (inicio.HasValue)
            {
                query = query.Where(x => x.Data >= inicio.Value);
            }

            if (fim.HasValue)
            {
                query = query.Where(x => x.Data <= fim.Value);
            }

            var totalReceitas = await query
                .Where(x => x.Categoria.Tipo == TipoCategoria.Receita)
                .SumAsync(x => (decimal?)x.Valor) ?? 0;

            var totalDespesas = await query
                .Where(x => x.Categoria.Tipo == TipoCategoria.Despesa)
                .SumAsync(c => (decimal?)c.Valor) ?? 0;

            return new RelatorioResumoResponse
            {
                TotalReceitas = totalReceitas,
                TotalDespesas = totalDespesas,
                SaldoTotal = totalReceitas - totalDespesas
            };
        }
    }
}
