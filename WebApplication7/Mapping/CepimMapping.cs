using AutoMapper;
using WebApplication7.Dtos;
using WebApplication7.Models;

namespace CepimMapping.Mapping
{
    public class CepimMapping : Profile
    {
        public CepimMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));

            CreateMap(typeof(ResponseGenerico<List<CepimResponse>>), typeof(ResponseGenerico<List<CepimResponse>>));

            CreateMap<CepimModel, CepimResponse>();

            CreateMap<ConvenioModel, ConvenioResponse>();

            CreateMap<OrgaoMaximoModel, OrgaoMaximoResponse>();

            CreateMap<OrgaoSuperiorModel, OrgaoSuperiorResponse>();

            CreateMap<PessoaJuridicaModel, PessoaJuridicaResponse>();
        }
    }
}