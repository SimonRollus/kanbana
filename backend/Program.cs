var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Hello World!";
})
.WithName("GetDefault");

app.Run();


