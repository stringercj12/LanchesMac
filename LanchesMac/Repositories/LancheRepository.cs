using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(categoria => categoria.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(lanche => lanche.IsLanchePreferido).Include(categoria => categoria.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
           return _context.Lanches.FirstOrDefault(lanche => lanche.LancheId == lancheId);
        }
    }
}
