using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Entities;
using Restaurant.Entities.Enums;
using Restaurant.Repositories.Interfaces;
using Restaurant.Shared;

namespace Restaurant.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeserosController : ControllerBase
    {
        private readonly IMeseroRepository _repository;
        public MeserosController(IMeseroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(MeseroDTO request)
        {

            var mesero = new Mesero
            {
                Nombres = request.Nombres,
                Apellidos = request.Apellidos,
                TipoDocumento = request.TipoDocumento,
                NumeroDocumento = request.NumeroDocumento,
                NumeroTelefono = request.NumeroTelefono,
                CorreoElectronico = request.CorreoElectronico
            };
            await _repository.AddAsync(mesero);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var mesero = await _repository.FindAsync(id);
            if (mesero is null)
            {
                return NotFound();
            }
            return Ok(mesero);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, MeseroDTO request)
        {
            var mesero = await _repository.FindAsync(id);
            if (mesero is null)
            {
                return NotFound();
            }
            mesero.Nombres = request.Nombres;
            mesero.Apellidos = request.Apellidos;
            mesero.TipoDocumento = TipoDocumento.DNI;
            mesero.NumeroDocumento = request.NumeroDocumento;
            mesero.NumeroTelefono = request.NumeroTelefono;
            mesero.CorreoElectronico = request.CorreoElectronico;

            await _repository.UpdateAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);

            return Ok();
        }

    }
}
