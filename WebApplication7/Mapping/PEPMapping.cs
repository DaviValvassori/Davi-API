using WebApplication7.Dtos;
using WebApplication7.Models;
using AutoMapper;

namespace PEPMapping.Mapping
{
    public class PEPMapping : Profile
    {
        public PEPMapping()
        {
            
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap(typeof(ResponseGenerico<List<PEPResponse>>), typeof(ResponseGenerico<List<PEPResponse>>));
            CreateMap<PEPResponse, PEPModel>();
            CreateMap<PEPModel, PEPResponse>();
        }
    }
}