using MyApplication.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapConfigurationRoutes();
app.Run();
