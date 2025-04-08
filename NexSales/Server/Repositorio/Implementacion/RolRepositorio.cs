using Microsoft.EntityFrameworkCore;
using SistemaVentanexsales.Server.Models;
using SistemaVentanexsales.Server.Repositorio.Contrato;

namespace SistemaVentanexsales.Server.Repositorio.Implementacion
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly DbventanexsalesContext _dbContext;

        public RolRepositorio(DbventanexsalesContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Rol>> Lista()
        {
            try
            {
                return await _dbContext.Rols.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
