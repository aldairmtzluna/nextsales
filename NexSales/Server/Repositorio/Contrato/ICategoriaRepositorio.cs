using SistemaVentanexsales.Server.Models;

namespace SistemaVentanexsales.Server.Repositorio.Contrato
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> Lista();
    }
}
