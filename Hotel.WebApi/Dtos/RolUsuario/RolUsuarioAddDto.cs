﻿namespace Hotel.Api.Dtos;

public record RolUsuarioAddDto : RolUsuarioDtoBase
{
    public DateTime FechaCreacion { get; set; }
}