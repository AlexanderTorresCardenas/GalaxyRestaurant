using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccess;
using Restaurant.Entities;
using Restaurant.Repositories.Implementaciones;
using Restaurant.Repositories.Interfaces;
using System.Data;

namespace Restaurant.Repositories.Implemntaciones;

public class ComandaRepositoty : RepositoryBase<Comanda>, IComandaRepository
{
    public ComandaRepositoty(RestaurantDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(Comanda entity)
    {
        await Context.AddAsync(entity);
    }

    public async Task ConfirmarTransaccionAsync()
    {
        await Context.Database.CommitTransactionAsync();
        await Context.SaveChangesAsync();
    }

    public async Task CrearTransaccionAsync()
    {
        await Context.Database.BeginTransactionAsync(IsolationLevel.Serializable);
    }

    public async Task ResetearTransaccionAsync()
    {
        await Context.Database.RollbackTransactionAsync();
    }

    public async Task<Dashboard> MostrarDashboard()
    {
        var entity = Context.Database.SqlQuery<Dashboard>($"EXEC dbo.uspDashboard");
        return await Task.FromResult(entity.AsEnumerable().First());
    }
}
