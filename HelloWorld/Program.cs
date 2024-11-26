var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseHealthChecks("/healthz");
app.MapControllers();

app.Run();
