﻿namespace Hotel.Domain;
using System.ComponentModel.DataAnnotations;

public class Habitacion : BaseEntity
{
    [Key]
    public required int IdHabitacion { get; set; }
    public string? Numero { get; set; }
    public string? Detalle { get; set; }
    public decimal Precio { get; set; }
    public int? IdEstadoHabitacion { get; set; }
    public int? IdPiso { get; set; }
    public int? IdCategoria { get; set; }

}
