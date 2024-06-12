using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;

namespace Restaurant.Repositories.Interfaces;

public interface IClienteRepository: IRepositoryBase<Cliente>
{
    Task<Cliente?> BuscarPorEmail(string email);
}
