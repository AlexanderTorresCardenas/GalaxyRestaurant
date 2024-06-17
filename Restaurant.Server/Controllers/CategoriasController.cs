using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;
using Restaurant.Shared;

namespace Restaurant.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        public CategoriasController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoriaDTO request)
        {

            var categoria = new Categoria
            {
                Descripcion = request.Descripcion,
                Comentarios = request.Comentarios
            };
            await _repository.AddAsync(categoria);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var categoria = await _repository.FindAsync(id);
            if (categoria is null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, CategoriaDTO request)
        {
            var categoria = await _repository.FindAsync(id);
            if (categoria is null)
            {
                return NotFound();
            }
            categoria.Descripcion = request.Descripcion;
            categoria.Comentarios = request.Comentarios;
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
