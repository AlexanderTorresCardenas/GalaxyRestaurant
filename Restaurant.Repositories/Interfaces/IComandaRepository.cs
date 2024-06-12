using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repositories.Interfaces
{
    public interface IComandaRepository : IRepositoryBase<Comanda>
    {
        Task CrearTransaccionAsync();

        Task ConfirmarTransaccionAsync();

        Task ResetearTransaccionAsync();

        Task<Dashboard> MostrarDashboard();
    }
}
