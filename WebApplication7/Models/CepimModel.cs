using System.Text.Json.Serialization;

namespace WebApplication7.Models;

public class CepimModel
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("dataReferencia")]
    public string dataReferencia { get; set; }

    [JsonPropertyName("motivo")]
    public string motivo { get; set; }

    [JsonPropertyName("orgaoSuperior")]
    public OrgaoSuperiorModel orgaoSuperior { get; set; }

    [JsonPropertyName("pessoaJuridica")]
    public PessoaJuridicaModel pessoaJuridica { get; set; }

    [JsonPropertyName("convenio")]
    public ConvenioModel convenio { get; set; }
    
}
public class ConvenioModel
{
    [JsonPropertyName("codigo")]
    public string codigo { get; set; }

    [JsonPropertyName("objeto")]
    public string objeto { get; set; }

    [JsonPropertyName("numero")]
    public string numero { get; set; }
}

public class OrgaoMaximoModel
{
    [JsonPropertyName("codigo")]
    public string codigo { get; set; }

    [JsonPropertyName("sigla")]
    public string sigla { get; set; }

    [JsonPropertyName("nome")]
    public string nome { get; set; }
}

public class OrgaoSuperiorModel
{
    [JsonPropertyName("nome")]
    public string nome { get; set; }

    [JsonPropertyName("codigoSIAFI")]
    public string codigoSIAFI { get; set; }

    [JsonPropertyName("cnpj")]
    public string cnpj { get; set; }

    [JsonPropertyName("sigla")]
    public string sigla { get; set; }

    [JsonPropertyName("descricaoPoder")]
    public string descricaoPoder { get; set; }

    [JsonPropertyName("orgaoMaximo")]
    public OrgaoMaximoModel orgaoMaximo { get; set; }
    
    
}

public class PessoaJuridicaModel
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("cpfFormatado")]
    public string cpfFormatado { get; set; }

    [JsonPropertyName("cnpjFormatado")]
    public string cnpjFormatado { get; set; }

    [JsonPropertyName("numeroInscricaoSocial")]
    public string numeroInscricaoSocial { get; set; }

    [JsonPropertyName("nome")]
    public string nome { get; set; }

    [JsonPropertyName("razaoSocialReceita")]
    public string razaoSocialReceita { get; set; }

    [JsonPropertyName("nomeFantasiaReceita")]
    public string nomeFantasiaReceita { get; set; }

    [JsonPropertyName("tipo")]
    public string tipo { get; set; }
}