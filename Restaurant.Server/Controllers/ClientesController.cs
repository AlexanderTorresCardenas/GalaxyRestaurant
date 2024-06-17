using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;
using Restaurant.Shared;

namespace Restaurant.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _repository;
    public ClientesController(IClienteRepository clienteRepository)
    {
        _repository = clienteRepository;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _repository.ListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post(ClienteDTO request)
    {

        var cliente = new Cliente
        {
            Nombres = request.Nombres,
            Apellidos = request.Apellidos,
            FechaCreacion = (DateTime)request.FechaNacimiento,
            TipoDocumento = request.TipoDocumento,
            NumeroDocumento = request.NumeroDocumento,
            NumeroTelefonoMovil = request.NumeroTelefonoMovil,
            CorreoElectronico = request.CorreoElectronico
        };
        await _repository.AddAsync(cliente);
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var cliente = await _repository.FindAsync(id);
        if (cliente is null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }
}
