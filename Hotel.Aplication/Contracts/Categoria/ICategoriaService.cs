﻿using Hotel.Aplication.Contracts.BaseService;
using Hotel.Aplication.Core;
using Hotel.Aplication.Dtos.Categoria;
using Hotel.Aplication.Models.Categoria;

namespace Hotel.Aplication.Contracts.Categoria
{
    public interface ICategoriaService : IBaseService<CategoriaGetModel, CategoriaAddDto, CategoriaUpdateDto>
    {

    }
}
