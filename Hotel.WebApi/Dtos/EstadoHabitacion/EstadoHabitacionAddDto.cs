﻿namespace Hotel.Api.Dtos;

public record EstadoHabitacionAddDto : EstadoHabitacionDtoBase
{
    public int Id { get; set; }
    public DateTime FechaCreacion { get; set; }
}
