using Restaurant.DataAccess;
using Restaurant.Entities;
using Restaurant.Repositories.Implementaciones;
using Restaurant.Repositories.Interfaces;

namespace Restaurant.Repositories.Implemntaciones;

public class MeseroRepository: RepositoryBase<Mesero>, IMeseroRepository
{
    public MeseroRepository(RestaurantDbContext context) : base(context)
    {
    }
}
