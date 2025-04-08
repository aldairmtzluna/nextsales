﻿using System.Linq.Expressions;

namespace SistemaVentanexsales.Client.Servicios.Contrato
{
    public interface IProductoService
    {
        Task<ResponseDTO<List<ProductoDTO>>> Lista();
        Task<ResponseDTO<ProductoDTO>> Crear(ProductoDTO entidad);
        Task<bool> Editar(ProductoDTO entidad);
        Task<bool> Eliminar(int id);
    }
}
