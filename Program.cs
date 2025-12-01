using LearningApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}

app.MapPlayerEndpoints();

app.Run();