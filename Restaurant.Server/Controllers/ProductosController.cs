using Microsoft.AspNetCore.Mvc;
using Restaurant.Entities;
using Restaurant.Repositories.Interfaces;
using Restaurant.Server.Services;
using Restaurant.Shared.Request;

namespace Restaurant.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly IProductoRepository _repository;
    private readonly IFileUploader _fileUploader;

    public ProductosController(IProductoRepository repository, IFileUploader fileUploader)
    {
        _repository = repository;
        _fileUploader = fileUploader;
    }

    // GET: api/productos
    // GET: api/productos?filtro=string
    [HttpGet]
    public async Task<IActionResult> Get(string? filtro)
    {
        return Ok(await _repository.ListarAsync(filtro));
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var registro = await _repository.FindAsync(id);
        if (registro is null)
        {
            return NotFound();
        }

        var response = new ProductoDTORequest
        {
            Id = registro.Id,
            Nombre = registro.Nombre,
            Descripcion = registro.Descripcion,
            Precio = registro.Precio,
            CategoriaId = registro.CategoriaId,
            UrlImagen = registro.UrlImagen
        };

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProductoDTORequest request)
    {
        var producto = new Producto
        {
            Nombre = request.Nombre,
            Descripcion = request.Descripcion,
            Precio = request.Precio,
            CategoriaId = request.CategoriaId
        };

        producto.UrlImagen = await _fileUploader.UploadFileAsync(request.Base64Imagen, request.NombreArchivo);

        await _repository.AddAsync(producto);

        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, ProductoDTORequest request)
    {
        var registro = await _repository.FindAsync(id);
        if (registro is null)
        {
            return NotFound();
        }

        registro.Nombre = request.Nombre;
        registro.Descripcion = request.Descripcion;
        registro.Precio = request.Precio;
        registro.CategoriaId = request.CategoriaId;
        
        if (!string.IsNullOrWhiteSpace(request.Base64Imagen))
        {
            registro.UrlImagen = await _fileUploader.UploadFileAsync(request.Base64Imagen, request.NombreArchivo);
        }
        
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