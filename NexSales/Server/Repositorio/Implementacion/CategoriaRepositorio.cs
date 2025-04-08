using Microsoft.EntityFrameworkCore;
using SistemaVentanexsales.Server.Models;
using SistemaVentanexsales.Server.Repositorio.Contrato;

namespace SistemaVentanexsales.Server.Repositorio.Implementacion
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly DbventanexsalesContext _dbContext;

        public CategoriaRepositorio(DbventanexsalesContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Categoria>> Lista()
        {
            try
            {
                return await _dbContext.Categoria.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
