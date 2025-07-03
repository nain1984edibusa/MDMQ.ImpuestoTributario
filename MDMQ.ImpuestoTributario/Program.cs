using MDMQ.ImpuestoTributario.Patentes.Datos.Contexts;
using MDMQ.ImpuestoTributario.Patentes.Datos.Implementacion;
using MDMQ.ImpuestoTributario.Patentes.Datos.Interfaz;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Implementacion;
using MDMQ.ImpuestoTributario.Patentes.Negocio.Interfaz;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MDMQ_CORE_TRIBUTARIOContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MDMQ_CORE_TRIBUTARIO_Connection")));

// Add services to the container.
builder.Services.AddScoped<IPatentes, Patentes>();
builder.Services.AddScoped<IBeneficioTributarioRepository, BeneficioTributario>(); // o la implementación real
builder.Services.AddScoped<ICatalogoNeg, CatalogoNeg>(); // o la implementación real
builder.Services.AddScoped<ICatalogoRepository, Catalogo>(); // o la implementación real
builder.Services.AddScoped<IConsultaSriNeg, ConsultaSriNeg>(); // o la implementación real
builder.Services.AddScoped<IConsultaSriRepository, ConsultaSri>(); // o la implementación real


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5177); // HTTP
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
