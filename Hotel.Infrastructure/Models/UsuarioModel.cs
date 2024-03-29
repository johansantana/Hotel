﻿namespace Hotel.Infrastructure;

public class Usuario
{
    public int IdUsuario { get; set; }
    public string? NombreCompleto { get; set; }
    public string? Correo { get; set; }
    public RolUsuario? RolUsuario { get; set; }
    public string? Clave { get; set; }
    public bool Estado { get; set; } = false;
    public DateTime FechaCreacion { get; set; } = new DateTime();
}
