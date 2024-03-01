﻿namespace Hotel.Api.Models;

public class RolUsuarioAddModel
{
    public int IdRolUsuario { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; } = false;
    public DateTime FechaCreacion { get; set; } = new DateTime();
}