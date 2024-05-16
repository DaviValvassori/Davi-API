using System.Dynamic;
using System.Net;
using Microsoft.AspNetCore.Antiforgery;

namespace WebApplication7.Dtos
{

    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set;  }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}