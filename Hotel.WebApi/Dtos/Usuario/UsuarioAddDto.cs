﻿namespace Hotel.Api.Dtos;

public record UsuarioAddDto : UsuarioDtoBase
{
    public DateTime FechaCreacion { get; set; }
}