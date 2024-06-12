using Restaurant.DataAccess;
using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;

namespace Restaurant.Repositories.Implementaciones;

public class CategoriaRepository(RestaurantDbContext context) :
    RepositoryBase<Categoria>(context), ICategoriaRepository;