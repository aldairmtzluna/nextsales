using SistemaVentanexsales.Server.Models;

namespace SistemaVentanexsales.Server.Repositorio.Contrato
{
    public interface IRolRepositorio
    {
        Task<List<Rol>> Lista();
    }
}
