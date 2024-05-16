using WebApplication7.Dtos;

namespace WebApplication7.Interfaces
{
    public interface ICepimService 
    {
        Task<ResponseGenerico<List<CepimResponse>>> BuscarPorCNPJ(string CNPJ);
    }
}