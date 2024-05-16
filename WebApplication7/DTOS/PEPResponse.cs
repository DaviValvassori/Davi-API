using System.Text.Json.Serialization;

namespace WebApplication7.Dtos
{

    public class PEPResponse
    {
        public string? Cpf { get; set; }

        public string? Nome { get; set; }

        public string? SiglaFuncao { get; set; }

        public string? DescricaoFuncao { get; set; }

        public string? NivelFuncao { get; set; }

        public string? CodOrgao { get; set; }

        public string? CpNomeOrgaof { get; set; }

        public string? DtInicioExercicio { get; set; }

        public string? DtFimExercicio { get; set; }

        public string? DtFimCarencia { get; set; }
       
    }
    
}