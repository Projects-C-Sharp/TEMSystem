using System.ComponentModel.DataAnnotations;

namespace TEMSystem.Models;

public class Event
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; }

    public string Ubicacion { get; set; }

    public string ImagenUrl { get; set; }
}