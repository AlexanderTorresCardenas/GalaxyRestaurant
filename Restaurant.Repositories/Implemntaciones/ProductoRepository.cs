using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess;
using Restaurant.Entities;
using Restaurant.Entities.Infos;
using Restaurant.Repositories.Interfaces;

namespace Restaurant.Repositories.Implementaciones;

public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
{
    public ProductoRepository(RestaurantDbContext context)
        : base(context)
    {
    }

    public async Task<ICollection<ProductoInfo>> ListarAsync(string? filtro)
    {
        var productos = Context.Set<Producto>()
            .Where(p => p.Estado)
            .AsQueryable();

        if (filtro is not null)
        {
            productos = productos.Where(p => p.Nombre.Contains(filtro));
        }

        return await productos
            .Select(x => new ProductoInfo
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                Categoria = x.Categoria.Descripcion,
                CategoriaId = x.CategoriaId,
                Precio = x.Precio,
                UrlImagen = x.UrlImagen
            })
            .AsNoTracking()
            .ToListAsync();
    }
}