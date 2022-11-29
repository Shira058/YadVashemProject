using Yad_Vashem.Middlewares;
using Yad_Vashem.Service;
using Yad_Vashem.Service.Interfaces;
using Yad_Vashem.Storage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITestimonyService, TestimonyService>();
builder.Services.AddScoped<ITestimonyStorage, TestimonyStorage>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHandlerErrorsMiddleware();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
