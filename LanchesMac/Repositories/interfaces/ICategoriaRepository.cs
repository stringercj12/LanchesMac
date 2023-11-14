using LanchesMac.Models;

namespace LanchesMac.Repositories.interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
