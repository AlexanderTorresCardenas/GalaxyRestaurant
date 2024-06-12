using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess;
using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;

namespace Restaurant.Repositories.Implementaciones;

public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
{
    public ClienteRepository(RestaurantDbContext context) : base(context)
    {
    }

    public async Task<Cliente?> BuscarPorEmail(string email)
    {
        return await Context.Set<Cliente>()
            .FirstOrDefaultAsync(o => o.CorreoElectronico == email);
    }
}
