public class CategoriaModel
{
    public int IdCategoria { get; set; }
    public string? Descripcion { get; set; }
    public bool? Estado { get; set; }
    public DateTime? FechaCreacion { get; set; } = new DateTime();
}