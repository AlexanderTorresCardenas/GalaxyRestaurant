namespace Restaurant.Entities.Infos;

public class ProductoInfo
{
    public int Id { get; set; }
    public string Nombre { get; set; } = default!;
    public string Descripcion { get; set; } = default!;
    public decimal Precio { get; set; }
    public string Categoria { get; set; } = default!;
    public int CategoriaId { get; set; }
    public string? UrlImagen { get; set; }
}