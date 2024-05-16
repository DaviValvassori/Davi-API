using WebApplication7.Dtos;
using WebApplication7.Models;

namespace WebApplication7.Interfaces;

public interface IDAPI
{
    Task<ResponseGenerico<List<PEPModel>>> BuscarPEPPorCpf(string Cpf);
    Task<ResponseGenerico<List<CepimModel>>> BuscarCepimPorCNPJ(string CNPJ);
    
}