using Restaurant.Entities;
using Restaurant.Entities.Infos;

namespace Restaurant.Repositories.Interfaces;

public interface IProductoRepository : IRepositoryBase<Producto>
{
    Task<ICollection<ProductoInfo>> ListarAsync(string? filtro);
}