﻿using Microsoft.Extensions.Logging;

namespace Hotel.Infrastructure;

public class EstadoHabitacionRepository : BaseRepository<EstadoHabitacion>, IEstadoHabitacionRepository
{
    private readonly HotelContext hotelContext;
    private readonly LoggerAdapter<EstadoHabitacionRepository> logger;

    public EstadoHabitacionRepository(HotelContext hotelContext, LoggerAdapter<EstadoHabitacionRepository> logger) : base(hotelContext)
    {
        this.hotelContext = hotelContext;
        this.logger = logger;
    }

    public override List<EstadoHabitacion> GetEntities()
    {
        return base.GetEntities();
    }

    public override List<EstadoHabitacion> FindAll(Func<EstadoHabitacion, bool> filter)
    {
        return hotelContext.EstadoHabitaciones.Where(filter).ToList();
    }

    public override void Add(EstadoHabitacion estadoHabitacion)
    {
        try
        {
            if (hotelContext.EstadoHabitaciones.Any(eh => eh.IdEstadoHabitacion == estadoHabitacion.IdEstadoHabitacion))
            {
                throw new EstadoHabitacionException("El estado de habitación se encuentra registrado.");
            }
            hotelContext.EstadoHabitaciones.Add(estadoHabitacion);
            hotelContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new EstadoHabitacionException("Error creando el estado de habitación. " + ex.ToString(), logger);
        }
    }

    public override void Update(EstadoHabitacion estadoHabitacion)
    {
        try
        {
            EstadoHabitacion estadoHabitacionUpdated = GetEntity(estadoHabitacion.IdEstadoHabitacion) ?? throw new EstadoHabitacionException("Estado de habitación no encontrado");
            estadoHabitacionUpdated.Descripcion = estadoHabitacion.Descripcion;
            estadoHabitacionUpdated.Estado = estadoHabitacion.Estado;
            hotelContext.EstadoHabitaciones.Update(estadoHabitacionUpdated);
            hotelContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new EstadoHabitacionException("Error actualizando el estado de habitación. " + ex.ToString(), logger);
        }
    }

    public override void Remove(EstadoHabitacion estadoHabitacion)
    {
        try
        {
            EstadoHabitacion estadoHabitacionDeleted = GetEntity(estadoHabitacion.IdEstadoHabitacion) ?? throw new EstadoHabitacionException("Estado de habitación no encontrado");
            hotelContext.EstadoHabitaciones.Remove(estadoHabitacionDeleted);
            hotelContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new EstadoHabitacionException("Error eliminando el estado de habitación. " + ex.ToString(), logger);
        }
    }
}
