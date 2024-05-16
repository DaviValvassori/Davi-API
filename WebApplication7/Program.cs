using Microsoft.EntityFrameworkCore;
using WebApplication7.Dados;
using WebApplication7.Interfaces;
using WebApplication7.Rest;
using WebApplication7.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DDados>(options =>
    options.UseNpgsql("Server=localhost;Port=5432;Database=MVPDavi;User Id=postgres;Password=postgres;Pooling=true;TimeZone=America/Sao_Paulo"));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICepimService, CepimService>();

builder.Services.AddSingleton<IPEPService, PEPService>();
builder.Services.AddSingleton<IDAPI, DAPIrest>();
builder.Services.AddAutoMapper(typeof(CepimMapping.Mapping.CepimMapping));
builder.Services.AddAutoMapper(typeof(PEPMapping.Mapping.PEPMapping));
//o mapping ta "errado"

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();