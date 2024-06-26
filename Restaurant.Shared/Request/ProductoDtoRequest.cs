﻿using System.ComponentModel.DataAnnotations;

namespace Restaurant.Shared.Request;

public class ProductoDTORequest
{
    public int Id { get; set; }
  
    [Required(ErrorMessage = Constantes.CampoRequerido)]
    [MaxLength(50)]
    public string Nombre { get; set; } = default!;

    [Required(ErrorMessage = Constantes.CampoRequerido)]
    public string Descripcion { get; set; } = default!;

    [Range(1, 9999, ErrorMessage = Constantes.ValidacionRango)]
    [Display(Name = "Precio")]
    public decimal Precio { get; set; }

    public int CategoriaId { get; set; }

    public string? UrlImagen { get; set; }

    public string? Base64Imagen { get; set; }
    public string? NombreArchivo { get; set; }
}