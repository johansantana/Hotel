﻿namespace Hotel.Api.Dtos;

public record HabitacionAddDto : HabitacionDtoBase
{
    public DateTime FechaCreacion { get; set; }
}
