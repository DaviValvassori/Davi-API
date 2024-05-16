using WebApplication7.Dtos;
using WebApplication7.Interfaces;
using AutoMapper;

namespace WebApplication7.Services
{

    public class PEPService : IPEPService
    {
        private readonly IDAPI _dapi;
        private readonly IMapper _mapper;
        public PEPService(IDAPI dapi, IMapper mapper)
        {
            _dapi = dapi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<List<PEPResponse>>> BuscarPorCPF(string CPF)
        {
            var cpf = await _dapi.BuscarPEPPorCpf(CPF);
            return _mapper.Map<ResponseGenerico<List<PEPResponse>>>(cpf);
        }
    }
}
