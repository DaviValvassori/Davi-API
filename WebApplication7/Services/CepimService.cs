using WebApplication7.Dtos;
using WebApplication7.Interfaces;
using AutoMapper;

namespace WebApplication7.Services
{

    public class CepimService : ICepimService
    {
        private readonly IDAPI _dapi;
        private readonly IMapper _mapper;
        public CepimService(IDAPI dapi, IMapper mapper)
        {
            _dapi = dapi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<List<CepimResponse>>> BuscarPorCNPJ(string CNPJ)
        {
            var cnpj = await _dapi.BuscarCepimPorCNPJ(CNPJ);
            return _mapper.Map<ResponseGenerico<List<CepimResponse>>>(cnpj);
        }
    }
}