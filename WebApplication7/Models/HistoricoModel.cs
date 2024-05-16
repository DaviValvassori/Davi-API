using Microsoft.EntityFrameworkCore;
using WebApplication7.Dados;

namespace WebApplication7.Models;


public class HistoricoModel 
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public DateTime Data { get; set; } 
    public string historico { get; set; }
    
    
}