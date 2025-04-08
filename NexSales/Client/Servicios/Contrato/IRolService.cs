namespace SistemaVentanexsales.Client.Servicios.Contrato
{
    public interface IRolService
    {
        Task<ResponseDTO<List<RolDTO>>> Lista();
    }
}
