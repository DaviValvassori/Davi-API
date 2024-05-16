namespace WebApplication7.Dtos;

public class CepimResponse
{
    
    public int? id { get; set; }
    public string? dataReferencia { get; set; }
    public string? motivo { get; set; }
    public OrgaoSuperiorResponse? orgaoSuperior { get; set; }
    public PessoaJuridicaResponse? pessoaJuridica { get; set; }
    public ConvenioResponse? convenio { get; set; }
}

public class ConvenioResponse
{
    public string? codigo { get; set; }
    public string? objeto { get; set; }
    public string? numero { get; set; }
}

public class OrgaoMaximoResponse
{
    public string? codigo { get; set; }
    public string? sigla { get; set; }
    public string? nome { get; set; }
}

public class OrgaoSuperiorResponse
{
    public string? nome { get; set; }
    public string? codigoSIAFI { get; set; }
    public string? cnpj { get; set; }
    public string? sigla { get; set; }
    public string? descricaoPoder { get; set; }
    public OrgaoMaximoResponse? orgaoMaximo { get; set; }
}

public class PessoaJuridicaResponse
{
    public int? id { get; set; }
    public string? cpfFormatado { get; set; }
    public string? cnpjFormatado { get; set; }
    public string? numeroInscricaoSocial { get; set; }
    public string? nome { get; set; }
    public string? razaoSocialReceita { get; set; }
    public string? nomeFantasiaReceita { get; set; }
    public string? tipo { get; set; }
}


