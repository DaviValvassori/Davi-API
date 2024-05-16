using WebApplication7.Dtos;

namespace WebApplication7.Interfaces
{
    public interface IPEPService 
    {
        Task<ResponseGenerico<List<PEPResponse>>> BuscarPorCPF(string CPF);
        
    }
}